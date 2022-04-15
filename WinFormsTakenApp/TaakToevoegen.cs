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
    public partial class TaakToevoegen : Form
    {

        DatabaseManeger db = new DatabaseManeger();
        int persoonId;
        int groepId;

        public TaakToevoegen()
        {
            InitializeComponent();
        }

        public TaakToevoegen(int persoonId , int groepId)
        {
            InitializeComponent();
            this. persoonId = persoonId;
            this.groepId = groepId;

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if(tbBeschrijving.Text != "" && tbNaam.Text != "")
            {
                db.TaakToevoegen(new Taak(tbNaam.Text, tbBeschrijving.Text, datePicker.Value), persoonId, groepId);
                MessageBox.Show("Taak toegevoed");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
                Form1 f = new Form1(persoonId , groepId);
                this.Hide();
                f.ShowDialog();
        }

        private void TaakToevoegen_Load(object sender, EventArgs e)
        {

        }
    }
}
