using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotellitehtava
{
    internal class HUONEET

    {
        YHDISTA yhdista = new YHDISTA();

        public DataTable huoneTyyppiLista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huoneet`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }

        public DataTable huoneTyyppi(int tyyppi)
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huone` WHERE `tyyppi`= @typ and vapaa='Kyllä'", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            komento.Parameters.Add("@typ", MySqlDbType.Int32).Value = tyyppi;
            adapter.SelectCommand = komento;
            adapter.Fill(table);
           

            return table;
        }

        public int haeHuoneTyyppi(int numero)
        {
            MySqlCommand komento = new MySqlCommand("SELECT `tyyppi` FROM `huone` WHERE vapaa='Kyllä `numero`=@num;", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public bool huoneVapaa(int numero, String Kyllä_or_EI)
        {
            MySqlCommand komento = new MySqlCommand("UPDATE `huone` SET `vapaa`=@Kyllä_EI WHERE `numero`=@num", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@Kyllä_EI", MySqlDbType.VarChar).Value = Kyllä_or_EI;

            yhdista.avaaYhteys();

            if(komento.ExecuteNonQuery() == 1)
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
        public bool lisaaHuone(int numero, int tyyppi, string puhelin, string vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `huone`(`numero`, `tyyppi`, `puhelin`, `vapaa`) VALUES (@num,@tp,@phn,@fr)";
            komento.CommandText = lisaaKysely;
            komento.Connection = yhdista.otaYhteys();
            // @enimi,@snimi,@lahi,@pnro)
            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            komento.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@fr", MySqlDbType.VarChar).Value = vapaa;

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
        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huone`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }
        public bool muokkaaHuone(int numero, int tyyppi, string puhelin, string vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            string muokkaaKysely = "UPDATE `huone` SET`tyyppi`= @tp,`puhelin`= @phn,`vapaa`= @fr WHERE `numero`= @num";
            komento.CommandText = muokkaaKysely;
            komento.Connection = yhdista.otaYhteys();
            // @enimi,@snimi,@lahi,@pnro)
            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            komento.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@fr", MySqlDbType.VarChar).Value = vapaa;

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

        public bool poistaHuone(int numero)
        {
            MySqlCommand komento = new MySqlCommand();
            string poistaKysely = "DELETE FROM `huone` WHERE `numero`= @num";
            komento.CommandText = poistaKysely;
            komento.Connection = yhdista.otaYhteys();
            //@num
            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

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
