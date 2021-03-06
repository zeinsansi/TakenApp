using DALMemoryStore.Exceptions;
using InterFaceLibrary;
using System.Data.SqlClient;

namespace DALMemoryStore
{
    public class TaakDAL : ITaakContainer
    {
        ConnectionDb connectionDb = new ConnectionDb();
        /// <summary>
        /// Zoekt een taak op van een bepaalde persoon in een bepaalde groep
        /// </summary>
        /// <param name="groepId">Groep Id</param>
        /// <param name="persoonId">Persoon Id</param>
        /// <returns>List van TaakDTOs</returns>
        public List<TaakDTO> FindByPersoonInGroep(int groepId, int persoonId)
        {
            try
            {
                List<TaakDTO> taken = new List<TaakDTO>();
                connectionDb.OpenConnection();
                string query = @"SELECT * FROM Taak 
                 WHERE persoonId = @persoonId AND groepId = @groepId";
                using (SqlCommand command = new(query, connectionDb.connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@persoonId", persoonId);
                    command.Parameters.AddWithValue("@groepId", groepId);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            taken.Add(new TaakDTO(
                                Convert.ToInt32(dr["Id"]),
                                dr["Naam"].ToString(),
                                dr["Beschrijving"].ToString(),
                                Convert.ToDateTime(dr["Deadline"]),
                                Convert.ToInt32(dr["persoonId"]),
                                Convert.ToInt32(dr["groepId"])));
                        }
                    }
                    connectionDb.CloseConnection();
                    return taken;
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
        /// Verwijdert een taak
        /// </summary>
        /// <param name="taak">Taak</param>
        public void Delete(int taakId)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("DELETE FROM Taak WHERE Id = @taakId", connectionDb.connection);
                command.Parameters.AddWithValue("@taakId", taakId);
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
        /// Voegt een taak toe
        /// </summary>
        /// <param name="taak">Taak</param>
        /// <param name="groepId">Groep Id</param>
        /// <param name="persoonId">Persoon Id</param>
        public void Create(TaakDTO taak)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("INSERT INTO Taak VALUES(@naam , @beshrijving , @deadline , @persoonId , @groepId)", connectionDb.connection);
                command.Parameters.AddWithValue("naam", taak.Naam);
                command.Parameters.AddWithValue("@beshrijving", taak.Beschrijving);
                command.Parameters.AddWithValue("@deadline", taak.Deadline);
                command.Parameters.AddWithValue("@persoonId", taak.PersoonId);
                command.Parameters.AddWithValue("@groepId", taak.GroepId);
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

        public TaakDTO FindById(int taakId)
        {
            try
            {
                connectionDb.OpenConnection();
                string query = @"SELECT * FROM Taak 
                 WHERE Id = @taakId";
                using (SqlCommand command = new(query, connectionDb.connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@taakId", taakId);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            return new TaakDTO(
                                Convert.ToInt32(dr["Id"]),
                                dr["Naam"].ToString(),
                                dr["Beschrijving"].ToString(),
                                Convert.ToDateTime(dr["Deadline"]),
                                Convert.ToInt32(dr["persoonId"]),
                                Convert.ToInt32(dr["groepId"]));
                        }
                    }
                    connectionDb.CloseConnection();
                    return null;
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

        public void Update(TaakDTO taak)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("UPDATE Taak SET Naam = @naam , Beschrijving = @beschrijving , Deadline = @deadline WHERE Id = @taakId", connectionDb.connection);
                command.Parameters.AddWithValue("@naam", taak.Naam);
                command.Parameters.AddWithValue("@beschrijving", taak.Beschrijving);
                command.Parameters.AddWithValue("@deadline", taak.Deadline);
                command.Parameters.AddWithValue("@taakId", taak.Id);
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
        public List<TaakDTO> FindByPersoon(int persoonId)
        {
            try
            {
                List<TaakDTO> taken = new List<TaakDTO>();
                connectionDb.OpenConnection();
                string query = @"SELECT * FROM Taak 
                 WHERE persoonId = @persoonId";
                using (SqlCommand command = new(query, connectionDb.connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@persoonId", persoonId);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            taken.Add(new TaakDTO(
                                Convert.ToInt32(dr["Id"]),
                                dr["Naam"].ToString(),
                                dr["Beschrijving"].ToString(),
                                Convert.ToDateTime(dr["Deadline"]),
                                Convert.ToInt32(dr["persoonId"]),
                                Convert.ToInt32(dr["groepId"])));
                        }
                    }
                    connectionDb.CloseConnection();
                    return taken;
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

    }
}
