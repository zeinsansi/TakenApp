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

        }

        private void lbMijnGroepen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilGroepList()
        {

        }


        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
        }

        private void lbGroepleden_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool parseResult = int.TryParse(lbGroepleden.SelectedValue.ToString(), out int persoonId);
            if (parseResult)
            {
                Form1 f = new();
                this.Hide();
                f.ShowDialog();
            }

        }

        private void btnVoegGroeplidToe_Click(object sender, EventArgs e)
        {
        }
    }
}
