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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaakToevoegen taak = new TaakToevoegen();
            this.Hide();
            taak.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lbxTaken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGreopForm_Click(object sender, EventArgs e)
        {
            MijnGroepn mg = new();
            this.Hide();
            mg.ShowDialog();

        }
    }

}
