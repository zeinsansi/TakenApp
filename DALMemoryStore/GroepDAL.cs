using DALMemoryStore.Exceptions;
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
        PersoonDAL persoonDAL = new PersoonDAL();
        /// <summary>
        /// Voegt een groep toe aan de database
        /// </summary>
        /// <param name="groep">GroepDTO</param>
        public GroepDTO Create(GroepDTO groep)
        {
            try
            {
                GroepDTO groepDTO = null;
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand(@"INSERT INTO Groep VALUES(@naam , @projectNaam, @projectBeshrijving)
                                            SELECT * FROM Groep 
                                            WHERE Naam = @naam and ProjectNaam = @projectNaam and ProjectBeshrijving = @projectBeshrijving", connectionDb.connection);
                command.Parameters.AddWithValue("@naam", groep.Naam);
                command.Parameters.AddWithValue("@projectNaam", groep.ProjectNaam);
                command.Parameters.AddWithValue("@projectBeshrijving", groep.ProjectNaam);
                command.ExecuteNonQuery();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        groepDTO = new GroepDTO(
                             dr["Naam"].ToString(),
                             Convert.ToInt32(dr["Id"]),
                             dr["ProjectNaam"].ToString(),
                             dr["ProjectBeshrijving"].ToString());
                    }
                }
                connectionDb.CloseConnection();
                return groepDTO;
            }
            catch (IOException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (InvalidOperationException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (Exception)
            {
                throw new PermanentDalException($"Er is iets fout gegaan");
            }
        }
        /// <summary>
        /// Haalt alle groepen op uit de database
        /// </summary>
        /// <returns>List met GroepDTOs</returns>
        public List<GroepDTO> GetAll()
        {
            try
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
                            dr["ProjectBeshrijving"].ToString(),
                            persoonDAL.FindByGroepId(Convert.ToInt32(dr["Id"]))));



                    }
                }
                connectionDb.CloseConnection();
                return groepen;
            }
            catch (TemporaryDalException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (PermanentDalException)
            {
                throw new PermanentDalException($"Er is iets fout gegaan");
            }
        }
        /// <summary>
        /// Verwijdert een groep uit de database
        /// </summary>
        /// <param name="dto">GroepDTO</param>
        public void Delete(GroepDTO dto)
        {
            try
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
            catch (TemporaryDalException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (PermanentDalException)
            {
                throw new PermanentDalException($"Er is iets fout gegaan");
            }
        }
        /// <summary>
        /// Voegt een bepaalde persoon toe aan een bepaalde groep
        /// </summary>
        /// <param name="groepId">Grope Id</param>
        /// <param name="gebruikersNaam">Persoon gebruikersnaam</param>
        public void VoegPersoonAanGroep(int groepId, string gebruikersNaam)
        {
            try
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
            catch (TemporaryDalException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (PermanentDalException)
            {
                throw new PermanentDalException($"Er is iets fout gegaan");
            }
        }
        /// <summary>
        /// Zoekt een bepaalde groep op met een bepaalde id
        /// </summary>
        /// <param name="id">Groep Id</param>
        /// <returns>GroepDTO</returns>
        public GroepDTO FindById(int id)
        {
            try
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
                        dto = LeesGroepUitDR(dr);
                    }
                }
                connectionDb.CloseConnection();
                return dto;
            }
            catch (TemporaryDalException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (PermanentDalException)
            {
                throw new PermanentDalException($"Er is iets fout gegaan");
            }
        }

        private static GroepDTO LeesGroepUitDR(SqlDataReader dr)
        {
            return new GroepDTO(
                dr["Naam"].ToString(),
                Convert.ToInt32(dr["Id"]),
                dr["ProjectNaam"].ToString(),
                dr["ProjectBeshrijving"].ToString());
        }

        public List<GroepDTO> FindByPersoon(int persoonId)
        {

            try
            {
                connectionDb.OpenConnection();
                List<GroepDTO> groepen = new List<GroepDTO>();
                string query = @"SELECT * FROM Groep 
                 INNER JOIN GroepPersoon on Groep.Id = GroepPersoon.groepId
                 WHERE GroepPersoon.persoonId = @persoonId";
                using (SqlCommand command = new(query, connectionDb.connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("persoonId", persoonId);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            groepen.Add(new GroepDTO(
                            dr["Naam"].ToString(),
                            Convert.ToInt32(dr["Id"]),
                            dr["ProjectNaam"].ToString(),
                            dr["ProjectBeshrijving"].ToString(),
                            persoonDAL.FindByGroepId(Convert.ToInt32(dr["Id"]))));
                        }
                    }
                    connectionDb.CloseConnection();
                    return groepen;
                }
            }
            catch (TemporaryDalException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (PermanentDalException)
            {
                throw new PermanentDalException($"Er is iets fout gegaan");
            }
        }

    }
}
