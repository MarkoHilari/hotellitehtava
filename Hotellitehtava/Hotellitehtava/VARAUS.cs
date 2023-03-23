using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Hotellitehtava
{
    internal class VARAUS
    {
        YHDISTA yhdista = new YHDISTA();
        public DataTable haeVaraukset()
        {

            

            MySqlCommand komento = new MySqlCommand("SELECT * FROM `varaukset`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }
        public bool lisaaVaraus(int numero, int asiakasID, DateTime paivaSisaan, DateTime paivaulos)
        {
            

            MySqlCommand komento = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `varaukset`(`huoneID`, `asiakasID`, `paivaSisaan`, `paivaulos`) VALUES (@rnm, @cid, @din, @dout)";
            komento.CommandText = lisaaKysely;
            komento.Connection = yhdista.otaYhteys();
            
            
            // @rnm, @cid, @din, @dout
            komento.Parameters.Add("@rnm", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@cid", MySqlDbType.Int32).Value = asiakasID;
            komento.Parameters.Add("@din", MySqlDbType.Date).Value = paivaSisaan;
            komento.Parameters.Add("@dout", MySqlDbType.Date).Value = paivaulos;

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

        public bool muokkaaVaraus(int varausID, int numero, int asiakasID, DateTime paivaSisaan, DateTime paivaulos)
        {
            MySqlCommand komento = new MySqlCommand();
            string muokkaaKysely = "UPDATE `varaukset` SET `huoneID`= @rnm,`asiakasID`= @cid,`paivaSisaan`= @din,`paivaulos`= @dout WHERE `varausID`= @rvid";
            komento.CommandText = muokkaaKysely;
            komento.Connection = yhdista.otaYhteys();
            // @rnm, @cid, @din, @dout, @rvid
            komento.Parameters.Add("@rvid", MySqlDbType.Int32).Value = varausID;
            komento.Parameters.Add("@rnm", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@cid", MySqlDbType.Int32).Value = asiakasID;
            komento.Parameters.Add("@din", MySqlDbType.Date).Value = paivaSisaan;
            komento.Parameters.Add("@dout", MySqlDbType.Date).Value = paivaulos;

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
        public bool poistaVaraus(int varausID)
        {
            MySqlCommand komento = new MySqlCommand();
            string poistaKysely = "DELETE FROM `varaukset` WHERE `varausID` = @rvid";
            komento.CommandText = poistaKysely;
            komento.Connection = yhdista.otaYhteys();
            //@num
            komento.Parameters.Add("@rvid", MySqlDbType.Int32).Value = varausID;

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
