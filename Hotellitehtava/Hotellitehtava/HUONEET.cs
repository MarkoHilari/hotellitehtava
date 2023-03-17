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
    }
}
