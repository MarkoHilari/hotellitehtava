using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Hotellitehtava
{
    internal class ASIAKAS
    {
        YHDISTA yhdista = new YHDISTA();
        public bool lisaaAsiakas(string enimi, string snimi, string lahi, string posti)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `asiakas`(`etu_nimi`, `suku_nimi`, `lahi_osoite`, `postinro`) VALUES (@enimi,@snimi,@lahi,@pnro)";
            komento.CommandText = lisaaKysely;
            komento.Connection = yhdista.otaYhteys();
            // @enimi,@snimi,@lahi,@pnro)
            komento.Parameters.Add("@enimi", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snimi", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@lahi", MySqlDbType.VarChar).Value = lahi;
            komento.Parameters.Add("@pnro", MySqlDbType.VarChar).Value = posti;

            yhdista.avaaYhteys();

            if (komento.ExecuteNonQuery() == 1)
            {
                yhdista.suljeYhteys();
                return true;
            }
            else
            {
                yhdista.suljeYhteys();
                return false;
            }

        }
        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `asiakas`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }

        public bool muokkaaAsiakasta(int tunnus, string enimi, string snimi, string lahi, string posti)
        {
            MySqlCommand komento = new MySqlCommand();
            string muokkaaKysely = "UPDATE `asiakas` SET `etu_nimi`='@enimi',`suku_nimi`='@snimi',`lahi_osoite`='@lahi',`postinro`='@pnro' WHERE `tunnus`='@id'";
            komento.CommandText = muokkaaKysely;
            komento.Connection = yhdista.otaYhteys();
            //@id,@enimi,@snimi,@lahi,@pnro)
            komento.Parameters.Add("@id", MySqlDbType.Int32).Value = tunnus;

            komento.Parameters.Add("@enimi", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snimi", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@lahi", MySqlDbType.VarChar).Value = lahi;
            komento.Parameters.Add("@pnro", MySqlDbType.VarChar).Value = posti;

            yhdista.avaaYhteys();

            if (komento.ExecuteNonQuery() == 1)
            {
                yhdista.suljeYhteys();
                return true;
            }
            else
            {
                yhdista.suljeYhteys();
                return false;
            }
        }
    }
}
