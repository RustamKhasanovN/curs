using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РасчетГСМ
{
    internal class db
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;port=3306; user id=root; Password= root; database= cardatabase;");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
