using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TaakVerdelingLibrary;

namespace TaakverdelingApp
{
    internal class DatabaseManeger
    {
        /// <summary>  De connection string van de database dbi490959  </summary>
        private static string connectionString = @"Server=mssqlstud.fhict.local;Database=dbi490959;User Id=dbi490959;Password=welkom123;";
        private SqlConnection connection;
        /// <summary> Opent de connection met de database </summary>
        private void OpenConnection()
        {
            try
            {
                this.connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch { return; }
        }

        /// <summary> stopt de connection met de database </summary>
        private void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch { return; }
        }
        /// <summary>
        /// Voegt een taak toe aan de databasetable Taak
        /// </summary>
        /// <param name="taak"></param>
        /// <param name="persoonId"></param>
        /// <param name="groepId"></param>
        public void TaakToevoegen(Taak taak, int persoonId, int groepId)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Taak VALUES(@naam , @beshrijving , @deadline , @persoonId , @groepId)", this.connection);
            command.Parameters.AddWithValue("naam", taak.GetNaam());
            command.Parameters.AddWithValue("@beshrijving", taak.GetBeschrijving());
            command.Parameters.AddWithValue("@deadline", taak.GetDeadLine());
            command.Parameters.AddWithValue("@persoonId", persoonId);
            command.Parameters.AddWithValue("@groepId", groepId);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// Haalt de taken  van een bepaalde persoon in een bepalde groep van de database
        /// </summary>
        /// <param name="persoonId"></param>
        /// <param name="groepId"></param>
        /// <returns>Table met taken</returns>
        public DataTable GetTaken(int persoonId, int groepId)
        {
            OpenConnection();
            string query = @"SELECT * FROM Taak 
                 WHERE persoonId = @persoonId AND groepId = @groepId";
            using (SqlCommand command = new(query, this.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@persoonId", persoonId);
                command.Parameters.AddWithValue("@groepId", groepId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
        }
        /// <summary>
        /// Weergeeft een bepaalde taak van de database toe
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Gegevens van een bepaalde taak</returns>
        public Taak TaakWeergeven(int id)
        {
            Taak taak = null;
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Taak WHERE Id = @id", this.connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    taak = new Taak(
                        dr["Naam"].ToString(),
                        dr["Beschrijving"].ToString(),
                        Convert.ToDateTime(dr["Deadline"]));
                }
            }
            CloseConnection();
            return taak;
        }

        /// <summary> Verwijdert een bepaalde taak van de databasetable Taak </summary>
        public void TaakVerwijderen(int taakId)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Taak WHERE Id = @taakId", this.connection);
            command.Parameters.AddWithValue("@taakId", taakId);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// Voegt een groep toe aan databasetable Groep
        /// </summary>
        /// <param name="groep"></param>
        public void GroepMaken(Groep groep)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Groep VALUES(@naam , @projectNaam, @projectBeshrijving)", this.connection);
            command.Parameters.AddWithValue("naam", groep.GetNaam());
            command.Parameters.AddWithValue("@projectNaam", groep.GetProjectNaam());
            command.Parameters.AddWithValue("@projectBeshrijving", groep.GetProjectBeschrijving());
            command.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// Haalt de groepen van de database
        /// </summary>
        /// <returns>Table met groepen</returns>
        public DataTable GetGroepen()
        {
            OpenConnection();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Groep", this.connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
        }
        /// <summary>
        /// Weergeeft een bepaalde groep van de database toe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Groep GroepWeergeven(int id)
        {
            Groep groep = null;
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Groep WHERE Id = @id", this.connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    groep = new Groep(
                        dr["Naam"].ToString(),
                        dr["ProjectNaam"].ToString(),
                        dr["ProjectBeshrijving"].ToString());
                }
            }
            CloseConnection();
            return groep;
        }
        /// <summary>
        /// Verwijdert een bepaalde groep van databasetable Groep
        /// </summary>
        /// <param name="Id"></param>
        public void GroepVerwijderen(int Id)
        {
            OpenConnection();
            string query = @"Delete GroepPersoon 
                where groepId = @Id
                Delete Taak
                where groepId = @Id
                Delete Groep
                where Id = @Id";
            SqlCommand command = new SqlCommand(query, this.connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// Haalt groepleden van een bepaalde groep van de database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetGroepleden(int id)
        {
            OpenConnection();
            string query = @"SELECT * FROM Persoon 
                 INNER JOIN GroepPersoon on Persoon.Id = GroepPersoon.persoonId
                 WHERE GroepPersoon.groepId = @id";
            using (SqlCommand command = new(query, this.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))

            {
                command.Parameters.AddWithValue("id", id);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        /// <summary>
        /// Voegt een bepaalde persoon aan een bepaalde groep toe
        /// </summary>
        /// <param name="groepId"></param>
        /// <param name="gebruikersNaam"></param>
        public void VoegGroeplidToe(int groepId, string gebruikersNaam)
        {
            OpenConnection();
            string query = @"INSERT INTO GroepPersoon
                VALUES (@groepId,
                (SELECT Id
                FROM   Persoon
                WHERE (Gebruikersnaam = @gebruikersNaam)), 1)";
            SqlCommand command = new SqlCommand(query, this.connection);
            command.Parameters.AddWithValue("@groepId", groepId);
            command.Parameters.AddWithValue("@gebruikersNaam", gebruikersNaam);
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }

}
