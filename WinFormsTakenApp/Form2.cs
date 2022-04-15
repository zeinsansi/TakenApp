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
    public partial class MijnGroepn : Form
    {
        DatabaseManeger db = new();
        int groepId;
        public MijnGroepn()
        {
            InitializeComponent();
        }

        private void btnGroepMaken_Click(object sender, EventArgs e)
        {
            GroepMaken g = new();
            this.Hide();
            g.ShowDialog();
        }

        private void MijnGroepn_Load(object sender, EventArgs e)
        {
            FilGroepList();
        }

        private void lbMijnGroepen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbGroepleden.SelectionMode = SelectionMode.None;
            FilGroepledenList();
            lbGroepleden.SelectionMode = SelectionMode.One;

        }

        private void FilGroepList()
        {
            lbMijnGroepen.DataSource = db.GetGroepen();
            lbMijnGroepen.DisplayMember = "Naam";
            lbMijnGroepen.ValueMember = "Id";
        }
        /// <summary>
        /// Vult de Groepleden listbox met goepleden van bepaalde groep
        /// </summary>
        private void FilGroepledenList()
        {          
            Int32.TryParse(lbMijnGroepen.SelectedValue.ToString(), out groepId);
            lbGroepleden.DataSource = db.GetGroepleden(groepId);
            lbGroepleden.DisplayMember = "Naam";
            lbGroepleden.ValueMember = "Id";
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            bool parseResult = int.TryParse(lbMijnGroepen.SelectedValue.ToString(), out int id);
            if (parseResult)
            {
                Groep groep = db.GroepWeergeven(Convert.ToInt32(lbMijnGroepen.SelectedValue));
                if (groep != null)
                {
                    DialogResult result = MessageBox.Show($"{groep}\n\nWil je deze groep verwijderen?", "Groep Beschrijving", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.GroepVerwijderen(Convert.ToInt32(lbMijnGroepen.SelectedValue));
                        FilGroepList();
                    }
                }
            }
        }

        private void lbGroepleden_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool parseResult = int.TryParse(lbGroepleden.SelectedValue.ToString(), out int persoonId);
            if (parseResult)
            {
                Form1 f = new(persoonId , groepId);
                this.Hide();
                f.ShowDialog();
            }

        }

        private void btnVoegGroeplidToe_Click(object sender, EventArgs e)
        {
            db.VoegGroeplidToe(groepId, tbGebruikerNaam.Text);
            lbGroepleden.SelectionMode = SelectionMode.None;
            FilGroepledenList();
            lbGroepleden.SelectionMode = SelectionMode.One;
        }
    }
}
