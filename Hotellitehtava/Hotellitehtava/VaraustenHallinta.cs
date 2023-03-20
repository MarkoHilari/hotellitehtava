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
    public partial class VaraustenHallinta : Form
    {
        public VaraustenHallinta()
        {
            InitializeComponent();
        }

        HUONEET huone = new HUONEET();

        private void VaraustenHallinta_Load(object sender, EventArgs e)
        {
            huonetyyppiCB.DataSource = huone.huoneTyyppiLista();
            huonetyyppiCB.DisplayMember = "nimike";
            huonetyyppiCB.ValueMember = "valikoima_id";
        }

        private void tyhjennaVarausKenttaBT_Click(object sender, EventArgs e)
        {
            varausNroTB.Text = "";
            asiakasNroCB.Text = "";
            huonetyyppiCB.SelectedIndex = 0;
            sisaanDTP.Value = DateTime.Now;
            ulosDTP.Value = DateTime.Now;
        }
    }
}
