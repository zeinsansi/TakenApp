using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data.SqlClient;
using static DALMemoryStore.JsonDatabase;
using DALMemoryStore.Exceptions;

namespace DALMemoryStore
{
    public class ConnectionDb
    {
        //TODO: Add connection string to config file
        public string data = File.ReadAllText(@"C:\Users\Windows 10 Pro\source\repos\TakenApp\DALMemoryStore\DatabaseConfig.json");
        public SqlConnection? connection;
        public Rootobject root;

        /// <summary>
        /// Opens a connection to the database
        /// </summary>
        public void OpenConnection()
        {
            root = JsonSerializer.Deserialize<Rootobject>(data);
            if (root != null)
            {
                connection = new SqlConnection(root.ConnectionString);
                connection.Open();
            }
        }
        /// <summary>
        /// Sluit de connectie met de database
        /// </summary>
        public void CloseConnection()
        {
            if (connection != null)
                connection.Close();
        }
    }
}
