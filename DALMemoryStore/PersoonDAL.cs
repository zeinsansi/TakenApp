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
    public class PersoonDAL : IPersoonContainer
    {
        ConnectionDb connectionDb = new ConnectionDb();
        /// <summary>
        /// Haalt alle personen in een bepaalde groep op uit de database
        /// </summary>
        /// <param name="groepId">Groep Id</param>
        /// <returns>List met PersoonDTOs</returns>
        public List<PersoonDTO> FindByGroepId(int groepId)
        {
            try
            {
                connectionDb.OpenConnection();
                List<PersoonDTO> Groepsleden = new List<PersoonDTO>();
                string query = @"SELECT * FROM Persoon 
                 INNER JOIN GroepPersoon on Persoon.Id = GroepPersoon.persoonId
                 WHERE GroepPersoon.groepId = @groepId";
                using (SqlCommand command = new(query, connectionDb.connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("groepId", groepId);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Groepsleden.Add(new PersoonDTO(
                                dr["Naam"].ToString(),
                                Convert.ToInt32(dr["Id"]),
                                dr["Gebruikersnaam"].ToString(),
                                dr["Email"].ToString()));
                        }
                    }
                    connectionDb.CloseConnection();
                    return Groepsleden;
                }
            }
            catch (SqlException)
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
        /// Voegt een persoon toe aan de database
        /// </summary>
        /// <param name="persoon">Persoon</param>
        /// <param name="newWachtwoord">Gebruiker new wachtwoord</param>
        public void Create(PersoonDTO persoon, string newWachtwoord)
        {
            try
            {
                string wachtwoordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(newWachtwoord, 13);
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("INSERT INTO Persoon VALUES(@naam , @gebruikersnaam, @email, @newWachtwoord)", connectionDb.connection);
                command.Parameters.AddWithValue("@naam", persoon.Naam);
                command.Parameters.AddWithValue("@gebruikersnaam", persoon.Gebruikersnaam);
                command.Parameters.AddWithValue("@email", persoon.Email);
                command.Parameters.AddWithValue("@newWachtwoord", wachtwoordHash);
                command.ExecuteNonQuery();
                connectionDb.CloseConnection();
            }
            catch (SqlException)
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
        /// Zoekt een persson uit met een bepaalde gebruikersnaam en wachtwoordhash
        /// </summary>
        /// <param name="gebruikernaam">Gebruikersnaam</param>
        /// <param name="wachtwoord">Wachtwoord</param>
        /// <returns></returns>
        public PersoonDTO LogIn(string gebruikernaam, string wachtwoord)
        {
            try
            {
                connectionDb.OpenConnection();
                PersoonDTO persoon = new PersoonDTO();
                SqlCommand command = new SqlCommand("SELECT WachtwoordHash, Id FROM Persoon WHERE Gebruikersnaam = @gebruikersnaam", connectionDb.connection);
                command.Parameters.AddWithValue("@gebruikersnaam", gebruikernaam);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        persoon.Id = Convert.ToInt32(dr["Id"]);
                        string WachtwoordHash = dr["WachtwoordHash"].ToString();
                        bool isValid = BCrypt.Net.BCrypt.EnhancedVerify(wachtwoord, WachtwoordHash);
                        if (isValid)
                        {
                            persoon = FindByID(persoon.Id);
                        }
                        else
                        {
                            persoon = null;
                        }
                    }
                }
                else
                {
                    persoon = null;
                }
                connectionDb.CloseConnection();
                return persoon;
            }
            catch (SqlException)
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
        /// Zoekt een persoon uit met een bepaalde id
        /// </summary>
        /// <param name="id">Persoon Id</param>
        /// <returns>PersoonDTO</returns>
        public PersoonDTO FindByID(int id)
        {
            try
            {
                connectionDb.OpenConnection();
                PersoonDTO persoon = new PersoonDTO();
                SqlCommand command = new SqlCommand("SELECT * FROM Persoon WHERE Id = @id", connectionDb.connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        persoon.Id = Convert.ToInt32(dr["Id"]);
                        persoon.Naam = dr["Naam"].ToString();
                        persoon.Gebruikersnaam = dr["Gebruikersnaam"].ToString();
                        persoon.Email = dr["Email"].ToString();
                    }
                }
                else
                {
                    persoon = null;
                }
                connectionDb.CloseConnection();
                return persoon;
            }
            catch (SqlException)
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
        public PersoonDTO FindByGebruikersnaam(string gebruikersnaam)
        {
            try
            {
                connectionDb.OpenConnection();
                PersoonDTO persoon = new PersoonDTO();
                SqlCommand command = new SqlCommand("SELECT * FROM Persoon WHERE Gebruikersnaam = @gebruikersnaam", connectionDb.connection);
                command.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        persoon.Id = Convert.ToInt32(dr["Id"]);
                        persoon.Naam = dr["Naam"].ToString();
                        persoon.Gebruikersnaam = dr["Gebruikersnaam"].ToString();
                        persoon.Email = dr["Email"].ToString();
                    }
                }
                else
                {
                    persoon = null;
                }
                connectionDb.CloseConnection();
                return persoon;
            }
            catch (SqlException)
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
    }
}
