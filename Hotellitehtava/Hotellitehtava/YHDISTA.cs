using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;

namespace Hotellitehtava
{
    /*
     * Tällä classilla yhdistetään yhteys sovelluksen ja MySql välillä
     */
    internal class YHDISTA
    {
        private MySqlConnection yhdista = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotellitietokanta");

        public MySqlConnection otaYhteys()         
        { 
          return yhdista; 
        }
        public void avaaYhteys()
        {
            if(yhdista.State == ConnectionState.Closed)
            {
                yhdista.Open();
            }
        }
        public void suljeYhteys()
        {
            if (yhdista.State == ConnectionState.Open)
            {
                yhdista.Close();
            }
        }
    }
}
