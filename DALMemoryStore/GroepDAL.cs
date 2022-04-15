using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMemoryStore
{
    public class GroepDAL : IGroepContainer
    {
        ConnectionDb connectionDb = new ConnectionDb();

        public void Create(GroepDTO groep)
        {
            connectionDb.OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Groep VALUES(@naam , @projectNaam, @projectBeshrijving)", connectionDb.connection);
            command.Parameters.AddWithValue("naam", groep.Naam);
            command.Parameters.AddWithValue("@projectNaam", groep.ProjectNaam);
            command.Parameters.AddWithValue("@projectBeshrijving", groep.ProjectNaam);
            command.ExecuteNonQuery();
            connectionDb.CloseConnection();
        }
        public List<GroepDTO> GetAll()
        {
            List<GroepDTO> groepen = new List<GroepDTO>();
            connectionDb.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Groep", connectionDb.connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    groepen.Add(new GroepDTO(
                        dr["Naam"].ToString(),
                        Convert.ToInt32(dr["Id"]),
                        dr["ProjectNaam"].ToString(),
                        dr["ProjectBeshrijving"].ToString()));

                }
            }
            connectionDb.CloseConnection();
            return groepen;
        }

        public void Delete(GroepDTO dto)
        {
            connectionDb.OpenConnection();
            string query = @"Delete GroepPersoon 
                where groepId = @Id
                Delete Taak
                where groepId = @Id
                Delete Groep
                where Id = @Id";
            SqlCommand command = new SqlCommand(query, connectionDb.connection);
            command.Parameters.AddWithValue("@Id", dto.Id);
            command.ExecuteNonQuery();
            connectionDb.CloseConnection();
        }

        public void VoegPersoonAanGroep(int groepId, string gebruikersNaam)
        {
            connectionDb.OpenConnection();
            string query = @"INSERT INTO GroepPersoon
                VALUES (@groepId,
                (SELECT Id
                FROM   Persoon
                WHERE (Gebruikersnaam = @gebruikersNaam)), 1)";
            SqlCommand command = new SqlCommand(query, connectionDb.connection);
            command.Parameters.AddWithValue("@groepId", groepId);
            command.Parameters.AddWithValue("@gebruikersNaam", gebruikersNaam);
            command.ExecuteNonQuery();
            connectionDb.CloseConnection();
        }

        public GroepDTO FindById(int id)
        {
            GroepDTO dto = null;
            connectionDb.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Groep WHERE Id = @id", connectionDb.connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dto = new GroepDTO(
                        dr["Naam"].ToString(),
                        Convert.ToInt32(dr["Id"]),
                        dr["ProjectNaam"].ToString(),
                        dr["ProjectBeshrijving"].ToString());
                }
            }
            connectionDb.CloseConnection();
            return dto;
        }
    }
}
