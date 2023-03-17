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
    public partial class HuoneidenHallinta : Form
    {
        public HuoneidenHallinta()
        {
            InitializeComponent();
        }
        HUONEET huone = new HUONEET();
        private void HuoneidenHallinta_Load(object sender, EventArgs e)
        {
            huoTyypCB.DataSource = huone.huoneTyyppiLista();
            huoTyypCB.DisplayMember = "nimike";
            huoTyypCB.ValueMember = "valikoima_id";

            hallintaDG.DataSource = huone.haeHuoneet();
        }

        private void lisaaHuoBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(huoneNroTB.Text);
            int tyyppi = Convert.ToInt32(huoTyypCB.SelectedValue.ToString());   
            string puhelin = hallintaPuhTB.Text;

            if(huone.lisaaHuone(numero, tyyppi, puhelin, "Yes"))
            {
                MessageBox.Show("Huone lisätty", "Lisää huone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huone anti lisätty", "Lisää huone", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void muokkaaHuoTB_Click(object sender, EventArgs e)
        {

        }

        private void poistaHuoTB_Click(object sender, EventArgs e)
        {

        }

        private void tyhjennaKenTB_Click(object sender, EventArgs e)
        {
            huoneNroTB.Text = "";
            huoTyypCB.SelectedIndex = 0;
            hallintaPuhTB.Text = "";
        }
    }
}
