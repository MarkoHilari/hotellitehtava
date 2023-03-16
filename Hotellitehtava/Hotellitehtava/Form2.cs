using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellitehtava
{
    public partial class paaikkuna : Form
    {
        public paaikkuna()
        {
            InitializeComponent();
        }

        private void paaikkuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void henkiloMS_Click(object sender, EventArgs e)
        {
            asiakkaidenhallinta hallitseCF = new asiakkaidenhallinta();
            hallitseCF.ShowDialog();
        }

        private void HuoneMS_Click(object sender, EventArgs e)
        {
            HuoneidenHallinta huoneRF = new HuoneidenHallinta();
            huoneRF.ShowDialog();
        }

        private void varausMS_Click(object sender, EventArgs e)
        {
            VaraustenHallinta varausRSVF = new VaraustenHallinta();
            varausRSVF.ShowDialog();
        }
    }
}
