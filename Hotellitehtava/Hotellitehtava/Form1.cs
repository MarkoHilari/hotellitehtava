using MySql.Data.MySqlClient;
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
    public partial class loginFM : Form
    {
        public loginFM()
        {
            InitializeComponent();
        }

        private void kirjauduBT_Click(object sender, EventArgs e)
        {
            YHDISTA yhteys = new YHDISTA();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            String kysely = "SELECT * FROM kayttajat WHERE kayttajanimi=@usn AND salasana=@pass";

            komento.CommandText = kysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@usn", MySqlDbType.VarChar).Value = ktunnusTB.Text;
            komento.Parameters.Add("@pass", MySqlDbType.VarChar).Value = salaSanaTB.Text;

            adapter.SelectCommand = komento;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //MessageBox.Show("Kyllä");
                //Avataan pääikkuna
                this.Hide();
                paaikkuna paaikkuna = new paaikkuna();
                paaikkuna.Show();
            }
            else
            {
                if (ktunnusTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjätunnus", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salaSanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Tarkista käyttäjätunnus tai salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
