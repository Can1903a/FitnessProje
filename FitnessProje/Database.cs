using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public class Database
    {
        private string connectionString;

        public Database(string connStr)
        {
            connectionString = connStr;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void OpenConnection(MySqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection(MySqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}

