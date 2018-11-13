using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Base
{
    class Connection
    {
        public MySqlConnection Create()
        {
            //string connectionString = "server=localhost;database=futebol;uid=root;password=1234;sslmode=none";
            string connectionString = "server=70.37.57.127;database=futebol;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
