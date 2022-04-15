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
    public partial class GroepMaken : Form
    {
        DatabaseManeger db = new();
        public GroepMaken()
        {
            InitializeComponent();
        }

        private void btnGroepMaken_Click(object sender, EventArgs e)
        {
            if (tbGreopNaam.Text != "" && tbProjectNaam.Text != "" && tbProjectBeshrijving.Text != "")
            {
                db.GroepMaken(new Groep(tbGreopNaam.Text , tbProjectNaam.Text, tbProjectBeshrijving.Text));
                MessageBox.Show("Groep gemaakt");
            }
        }

        private void btnTerugGroep_Click(object sender, EventArgs e)
        {
            MijnGroepn mg = new MijnGroepn();
            this.Hide();
            mg.ShowDialog();
        }
    }
}

