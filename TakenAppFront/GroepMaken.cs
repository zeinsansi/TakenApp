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
    public partial class GroepMaken : Form
    {
        GroepContainer groepContainer = new GroepContainer(new GroepDAL());
        public GroepMaken()
        {
            InitializeComponent();
        }

        private void btnGroepMaken_Click(object sender, EventArgs e)
        {
            if (tbGreopNaam.Text != "" && tbProjectNaam.Text != "" && tbProjectBeshrijving.Text != "")
            {
                Groep groep = new Groep(tbGreopNaam.Text, tbProjectNaam.Text, tbProjectBeshrijving.Text);
                groepContainer.Create(groep);
                MessageBox.Show("Groep is aangemaakt");
            }
            else
            {
                MessageBox.Show("Vul alle velden in");
            }
        }

        private void btnTerugGroep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
           
    }
}

