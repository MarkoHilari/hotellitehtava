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
    public partial class asiakkaidenhallinta : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public asiakkaidenhallinta()
        {
            InitializeComponent();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            etuTB.Text = "";
            sukuTB.Text = "";
            lahiTB.Text = "";
            postinroTB.Text = "";
            kauttajaTB.Text = "";
            salasTB.Text = "";
        }

        private void uusiAsBT_Click(object sender, EventArgs e)
        {
            string enimi = etuTB.Text;
            string snimi = sukuTB.Text;
            string lahi = lahiTB.Text;
            string postinro = postinroTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || lahi.Trim().Equals(""))
            {
                MessageBox.Show("Vaaditut kentät - Etunimi & Sukunimi + Osoite", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaaAsiaka = asiakas.lisaaAsiakas(enimi, snimi, lahi, postinro);

                if (lisaaAsiaka)
                {
                    dataGridView1.DataSource = asiakas.haeAsiakkaat();

                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Lisää asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Asiakasta ei lisätty", "Lisää asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }

        private void asiakkaidenhallinta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = asiakas.haeAsiakkaat();
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            int id;
            string enimi = etuTB.Text;
            string snimi = sukuTB.Text;
            string lahi = lahiTB.Text;
            string postinro = postinroTB.Text;

            try
            {
                id = Convert.ToInt32(kauttajaTB.Text);
                if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || lahi.Trim().Equals(""))
                {
                    MessageBox.Show("Vaaditut kentät - Etunimi & Sukunimi + Osoite", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Boolean lisaaAsiakas = asiakas.muokkaaAsiakasta(id, enimi, snimi, lahi, postinro);

                    if (lisaaAsiakas)
                    {
                        dataGridView1.DataSource = asiakas.haeAsiakkaat();

                        MessageBox.Show("Asiakas tiedot päivitetty onnistuneesti", "Muokkaa asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Asiakasta ei päivitetty", "Muokkaa asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Virhe",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            }
        }

     //punaista alapuolella jatkuu

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kauttajaTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            etuTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sukuTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lahiTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            postinroTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
