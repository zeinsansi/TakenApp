using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaakverdelingApp
{
    public partial class TaakToevoegen : Form
    {


        public TaakToevoegen()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if(tbBeschrijving.Text != "" && tbNaam.Text != "")
            {
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
        }
        
        private void TaakToevoegen_Load(object sender, EventArgs e)
        {

        }
    }
}
