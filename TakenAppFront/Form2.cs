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
    public partial class MijnGroepn : Form
    {
        GroepContainer groepContainer = new GroepContainer(new GroepDAL());
        PersoonContainer persoonContainer = new PersoonContainer(new PersoonDAL());

        public MijnGroepn()
        {
            InitializeComponent();
        }

        private void btnGroepMaken_Click(object sender, EventArgs e)
        {
            GroepMaken g = new();
            g.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            g.ShowDialog();
        }
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            this.lbMijnGroepen.DataSource = this.groepContainer.GetAll();
        }

        private void MijnGroepn_Load(object sender, EventArgs e)
        {
            lbMijnGroepen.DataSource = groepContainer.GetAll();
            lbMijnGroepen.DisplayMember = "Naam";
        }

        private void lbMijnGroepen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Groep g = (Groep)lbMijnGroepen.SelectedItem;
            lbGroepleden.DataSource = persoonContainer.FindByGroepId(g.Id);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Groep g = (Groep)lbMijnGroepen.SelectedItem;
            DialogResult result = MessageBox.Show($"{g.ToString()}\n\nWil je deze groep verwijderen?", "Groep Beschrijving", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                groepContainer.Delete(g);
                lbMijnGroepen.DataSource = groepContainer.GetAll();
            }

        }

        private void btnVoegGroeplidToe_Click(object sender, EventArgs e)
        {
            Groep g = (Groep)lbMijnGroepen.SelectedItem;
            groepContainer.VoegPersoonAanGroep(g.Id, tbGebruikerNaam.Text);
            lbGroepleden.DataSource = persoonContainer.FindByGroepId(g.Id);
        }

        private void lbGroepleden_DoubleClick(object sender, EventArgs e)
        {
            if (lbGroepleden.SelectedItem != null)
            {
                Groep g = (Groep)lbMijnGroepen.SelectedItem;
                Persoon p = (Persoon)lbGroepleden.SelectedItem;
                Form1 f = new(g.Id, p.Id);
                f.ShowDialog();
            }
        }
    }
}
