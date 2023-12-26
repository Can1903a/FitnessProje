using System;
using System.Collections.Generic;
using System.Data;
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
        // Database sınıfınıza GetAntrenmanListesi metodunu ekleyin
        public DataTable GetAntrenmanListesi()
        {
            using (MySqlConnection connection = GetConnection())
            {
                OpenConnection(connection);

                string query = "SELECT * FROM antrenmanlar";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable antrenmanTable = new DataTable();
                        adapter.Fill(antrenmanTable);

                        return antrenmanTable;
                    }
                }
            }
        }

    }
}

