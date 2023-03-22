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
        VARAUS varaus = new VARAUS();

        private void VaraustenHallinta_Load(object sender, EventArgs e)
        {
            huonetyyppiCB.DataSource = huone.huoneTyyppiLista();
            huonetyyppiCB.DisplayMember = "nimike";
            huonetyyppiCB.ValueMember = "valikoima_id";

           int tyyppi = Convert.ToInt32(huonetyyppiCB.SelectedValue.ToString());
            huoneenNumeroCB.DataSource = huone.huoneTyyppi(tyyppi);
            huoneenNumeroCB.DisplayMember = "numero";
            huoneenNumeroCB.ValueMember = "numero";

            varausDG.DataSource = varaus.haeVaraukset();

        }

                

        private void tyhjennaVarausKenttaBT_Click(object sender, EventArgs e)
        {
            
            asiakasNroTB.Text = "";
            huonetyyppiCB.SelectedIndex = 0;
            sisaanDTP.Value = DateTime.Now;
            ulosDTP.Value = DateTime.Now;
        }

        private void huonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tyyppi = Convert.ToInt32(huonetyyppiCB.SelectedValue.ToString());
                huoneenNumeroCB.DataSource = huone.huoneTyyppi(tyyppi);
                huoneenNumeroCB.DisplayMember = "numero";
                huoneenNumeroCB.ValueMember = "numero";
            }
            catch(Exception) 
            { 
                //Elä tee yhtää mittää
            }
            
        }

        private void uusiVarausBT_Click(object sender, EventArgs e)
        {
            try
            {
                int asiakasID = Convert.ToInt32(asiakasNroTB.Text);

                int huoneNRO = Convert.ToInt32(huoneenNumeroCB.SelectedValue);
                DateTime sisaan = sisaanDTP.Value;
                DateTime ulos = ulosDTP.Value;

                if(sisaan < DateTime.Now)
                {
                    MessageBox.Show("Päivä pitää olla tämä päivä tai myöhempi", "Virheellinen sisäänkirjaamis päivä ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ulos < sisaan) 
                {
                    MessageBox.Show("Uloskirjaaminen pitää olla myöhempi kuin sisäänkirjaamispäivä", "Virheellinen uloskirjaamispäivä", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                }
                else
                {
                    if (varaus.lisaaVaraus(huoneNRO, asiakasID, sisaan, ulos))
                    {
                        huone.huoneEI(huoneNRO);
                        MessageBox.Show("Uusi varaus lisätty", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Uusi varaus anti lisätty", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }
            catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Lisää varaus virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void muokkaaVarausBT_Click(object sender, EventArgs e)
        {
            try
            {
                int asiakasID = Convert.ToInt32(asiakasNroTB.Text);

                int huoneNRO = Convert.ToInt32(huoneenNumeroCB.SelectedValue);
                DateTime sisaan = sisaanDTP.Value;
                DateTime ulos = ulosDTP.Value;

                if (sisaan < DateTime.Now)
                {
                    MessageBox.Show("Päivä pitää olla tämä päivä tai myöhempi", "Virheellinen sisäänkirjaamis päivä ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ulos < sisaan)
                {
                    MessageBox.Show("Uloskirjaaminen pitää olla myöhempi kuin sisäänkirjaamispäivä", "Virheellinen uloskirjaamispäivä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (varaus.muokkaaVaraus(huoneNRO, asiakasID, sisaan, ulos))
                    {
                        huone.huoneEI(huoneNRO);
                        MessageBox.Show("Uusi varaus lisätty", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Uusi varaus anti lisätty", "Uusi varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lisää varaus virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void varausDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            varausTB.Text = varausDG.CurrentRow.Cells[0].Value.ToString();
            asiakasNroTB.Text = varausDG.CurrentRow.Cells[1].Value.ToString();
            huoneenNumeroCB.SelectedValue = varausDG.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
//ALTER TABLE huone ADD CONSTRAINT fk_type_id FOREIGN KEY (tyyppi) REFERENCES huoneet(valikoima_id) on UPDATE CASCADE on DELETE CASCADE;

//ALTER TABLE varaukset add CONSTRAINT fk_room_number FOREIGN KEY (huoneID) REFERENCES huone(numero) on UPDATE CASCADE on DELETE CASCADE;

//ALTER TABLE varaukset add CONSTRAINT fk_client_id FOREIGN KEY (asiakasID) REFERENCES asiakas(tunnus) on UPDATE CASCADE on DELETE CASCADE;