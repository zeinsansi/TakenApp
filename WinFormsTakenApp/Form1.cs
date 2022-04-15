using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaakVerdelingLibrary;



namespace TaakverdelingApp
{
    public partial class Form1 : Form
    {
        DatabaseManeger db = new DatabaseManeger();
        int persoonId;
        int groepId;
        public Form1()
        {
            InitializeComponent();           
        }
        public Form1(int persoonId , int groepId)
        {
            InitializeComponent();
            this. persoonId = persoonId;
            this. groepId = groepId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                TaakToevoegen taak = new TaakToevoegen(persoonId , groepId);
                this.Hide();
                taak.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilTakenList();

        }

        private void lbxTaken_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool parseResult = int.TryParse(lbxTaken.SelectedValue.ToString(),out int id);
            if (parseResult)
            {
                Taak taak = db.TaakWeergeven(Convert.ToInt32(lbxTaken.SelectedValue));
                if (taak != null)
                {
                    DialogResult result = MessageBox.Show($"{taak}\n\nWil je deze taak verwijderen?", "Taak Beschrijving", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.TaakVerwijderen(Convert.ToInt32(lbxTaken.SelectedValue));
                        FilTakenList();
                    }
                }
            }

        }

        private void btnGreopForm_Click(object sender, EventArgs e)
        {
            MijnGroepn mg = new();
            this.Hide();
            mg.ShowDialog(); 

        }
        /// <summary>
        /// Vult de Taken listbox met Taken van een bepaalde persoon in een bepaalde groep
        /// </summary>
        private void FilTakenList()
        {
            lbxTaken.DataSource = db.GetTaken(persoonId , groepId);
            lbxTaken.DisplayMember = "Naam";
            lbxTaken.ValueMember = "Id";
        }
    }

    
}
