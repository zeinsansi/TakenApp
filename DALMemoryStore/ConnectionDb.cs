using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data.SqlClient;
using static DALMemoryStore.JsonDatabase;

namespace DALMemoryStore
{
    public class ConnectionDb
    {
        public string data = File.ReadAllText(@"C:\Users\Windows 10 Pro\source\repos\TakenApp\DALMemoryStore\DatabaseConfig.json");
        public SqlConnection? connection;
        public Rootobject root;
        /// <summary>
        /// Connect naar de database
        /// </summary>
        public void OpenConnection()
        {

            try
            {
                root = JsonSerializer.Deserialize<Rootobject>(data);
                if (root != null)
                {
                    connection = new SqlConnection(root.ConnectionString);
                    connection.Open();
                }
            }
            catch { }
        }
        /// <summary>
        /// Sluit de connectie met de database
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (connection != null)
                    connection.Close();
            }
            catch { }
        }
    }
}
