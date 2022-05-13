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
    public partial class TaakToevoegen : Form
    {
        TaakContainer taakContainer = new TaakContainer(new TaakDAL());
        int groepId;
        int persoonId;
        public TaakToevoegen()
        {
            InitializeComponent();
        }
        public TaakToevoegen(int groepId, int persoonId)
        {
            InitializeComponent();
            this.groepId = groepId;
            this.persoonId = persoonId;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (tbBeschrijving.Text != "" && tbNaam.Text != "")
            {
                Taak taak = new Taak(tbNaam.Text, tbBeschrijving.Text, dpDeadline.Value, persoonId, groepId);
                taakContainer.Create(taak);
                MessageBox.Show("Taak toegevoegd");
            }
            else
            {
                MessageBox.Show("Vul alle velden in");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(groepId, persoonId);
            this.Close();
            f.Refresh();
        }

        private void TaakToevoegen_Load(object sender, EventArgs e)
        {

        }
    }
}
