using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
           
            int tyyppi = Convert.ToInt32(huoTyypCB.SelectedValue.ToString());   
            string puhelin = hallintaPuhTB.Text;
            string vapaa = "";


            try
            {
                int numero = Convert.ToInt32(huoneNroTB.Text);

                if (radioButtonYes.Checked)
                {
                    vapaa = "KYLLÄ";
                }
                else if (radioButtonNo.Checked)
                {
                    vapaa = "EI";
                }

                if (huone.lisaaHuone(numero, tyyppi, puhelin, vapaa))
                {
                    hallintaDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone lisätty", "Lisää huone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huone anti lisätty", "Lisää huone", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
                catch(Exception ex)
                    {
                MessageBox.Show(ex.Message, "Huone numero fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                    }
            
        }

        private void muokkaaHuoTB_Click(object sender, EventArgs e)
        {
            
            int tyyppi = Convert.ToInt32(huoTyypCB.SelectedValue.ToString());
            string puhelin = hallintaPuhTB.Text;
            string vapaa = "";

            try
            {
                int numero = Convert.ToInt32(huoneNroTB.Text);

                if (radioButtonYes.Checked)
                {
                    vapaa = "KYLLÄ";

                }
                else if (radioButtonNo.Checked)
                {
                    vapaa = "EI";
                }
                if (huone.muokkaaHuone(numero, tyyppi, puhelin, vapaa))
                {
                    hallintaDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone päivitetty", "Huoneen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huone EI päivitetty", "Huoneen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }  
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero Fatal error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void poistaHuoTB_Click(object sender, EventArgs e)
        {
            try
            {

                int numero = Convert.ToInt32(huoneNroTB.Text);

                if (huone.poistaHuone(numero))
                {
                    hallintaDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huone EI poistettu", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tyhjennaKenTB_Click(object sender, EventArgs e)
        {
            huoneNroTB.Text = "";
            huoTyypCB.SelectedIndex = 0;
            hallintaPuhTB.Text = "";
            radioButtonYes.Checked = true;
        }

        private void hallintaDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huoneNroTB.Text = hallintaDG.CurrentRow.Cells[0].Value.ToString();
            huoTyypCB.SelectedValue = hallintaDG.CurrentRow.Cells[1].Value;
            hallintaPuhTB.Text = hallintaDG.CurrentRow.Cells[2].Value.ToString();

            string vapaa = hallintaDG.CurrentRow.Cells[3].Value.ToString();

            if (vapaa.Equals("KYLLÄ"))
            {
                radioButtonYes.Checked = true;
            }
            else if(vapaa.Equals("EI"))
            { 
                radioButtonNo.Checked = true;
            }
        }
    }
}
