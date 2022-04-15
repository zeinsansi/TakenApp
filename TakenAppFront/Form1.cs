using BusnLogicTakenApp;
using DALMemoryStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TakenAppFront
{
    public partial class Form1 : Form
    {
        int groepId;
        int persoonId;
        TaakContainer taakContainer = new TaakContainer(new TaakDAL());
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int groepId, int persoonId)
        {
            InitializeComponent();
            this.groepId = groepId;
            this.persoonId = persoonId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaakToevoegen taak = new TaakToevoegen(groepId, persoonId);
            taak.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            taak.ShowDialog();
        }
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            lbxTaken.DataSource = taakContainer.FindByPersoonInGroep(groepId, persoonId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxTaken.DataSource = taakContainer.FindByPersoonInGroep(groepId, persoonId);
        }

        private void lbxTaken_SelectedIndexChanged(object sender, EventArgs e)
        {
            Taak taak = (Taak)lbxTaken.SelectedItem;
            NaamLabel.Text = taak.Naam;
            beschrijvingLabel.Text = taak.Beschrijving;
            deadlineLabel.Text = taak.Deadline.ToString();
        }

        private void btnGreopForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaakVerwijderen_Click(object sender, EventArgs e)
        {
            Taak taak = (Taak)lbxTaken.SelectedItem;
            DialogResult result = MessageBox.Show($"{taak.ToString()}\nBent u klaar met deze taak?", "Taak Verwijderen?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                taakContainer.Delete(taak);
                lbxTaken.DataSource = taakContainer.FindByPersoonInGroep(groepId, persoonId);
            }
        }
    }
}
