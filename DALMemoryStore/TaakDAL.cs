using InterFaceLibrary;
using System.Data.SqlClient;

namespace DALMemoryStore
{
    public class TaakDAL : ITaakContainer
    {
        ConnectionDb connectionDb = new ConnectionDb();

        public List<TaakDTO> FindByPersoonInGroep(int groepId, int persoonId)
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
                            Convert.ToDateTime(dr["Deadline"])));
                    }
                }
                connectionDb.CloseConnection();
                return taken;
            }
        }

        public void Delete(TaakDTO taak) 
        {
            connectionDb.OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Taak WHERE Id = @taakId", connectionDb.connection);
            command.Parameters.AddWithValue("@taakId", taak.Id);
            command.ExecuteNonQuery();
            connectionDb.CloseConnection();
        }

        public void Create(TaakDTO taak, int groepId, int persoonId)
        {
            connectionDb.OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Taak VALUES(@naam , @beshrijving , @deadline , @persoonId , @groepId)", connectionDb.connection);
            command.Parameters.AddWithValue("naam", taak.Naam);
            command.Parameters.AddWithValue("@beshrijving", taak.Beschrijving);
            command.Parameters.AddWithValue("@deadline", taak.Deadline);
            command.Parameters.AddWithValue("@persoonId", persoonId);
            command.Parameters.AddWithValue("@groepId", groepId);
            command.ExecuteNonQuery();
            connectionDb.CloseConnection();
        }
    }
}