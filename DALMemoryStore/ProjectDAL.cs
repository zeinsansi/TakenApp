using DALMemoryStore.Exceptions;
using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMemoryStore
{
    public class ProjectDAL : IProjectContainer
    {
        ConnectionDb connectionDb = new ConnectionDb();
        
        public void Create(ProjectDTO projectDTO)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("INSERT INTO Project VALUES(@naam , @beshrijving , @groepId)", connectionDb.connection);
                command.Parameters.AddWithValue("@naam", projectDTO.Naam);
                command.Parameters.AddWithValue("@beshrijving", projectDTO.Beschrijving);
                command.Parameters.AddWithValue("@groepId", projectDTO.GroepId);
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

        public void Delete(ProjectDTO projectDTO)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("DELETE FROM Project WHERE id = @id", connectionDb.connection);
                command.Parameters.AddWithValue("@id", projectDTO.Id);
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

        public ProjectDTO FindByGroep(int groepId)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Project WHERE groepId = @groepId", connectionDb.connection);
                command.Parameters.AddWithValue("@groepId", groepId);
                SqlDataReader reader = command.ExecuteReader();
                ProjectDTO projectDTO = new ProjectDTO();
                while (reader.Read())
                {
                    projectDTO.Id = reader.GetInt32(0);
                    projectDTO.Naam = reader.GetString(1);
                    projectDTO.Beschrijving = reader.GetString(2);
                    projectDTO.GroepId = reader.GetInt32(3);
                }
                connectionDb.CloseConnection();
                return projectDTO;
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

        public ProjectDTO GetProject(int id)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Project WHERE Id = @id", connectionDb.connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                ProjectDTO projectDTO = new ProjectDTO();
                while (reader.Read())
                {
                    projectDTO.Id = reader.GetInt32(0);
                    projectDTO.Naam = reader.GetString(1);
                    projectDTO.Beschrijving = reader.GetString(2);
                    projectDTO.GroepId = reader.GetInt32(3);
                }
                connectionDb.CloseConnection();
                return projectDTO;
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

        public void Update(ProjectDTO projectDTO)
        {
            try
            {
                connectionDb.OpenConnection();
                SqlCommand command = new SqlCommand("UPDATE Project SET Naam = @naam , Beschrijving = @beschrijving  WHERE Id = @id", connectionDb.connection);
                command.Parameters.AddWithValue("@naam", projectDTO.Naam);
                command.Parameters.AddWithValue("@beschrijving", projectDTO.Beschrijving);
                command.Parameters.AddWithValue("@groepId", projectDTO.GroepId);
                command.Parameters.AddWithValue("@id", projectDTO.Id);
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
    }
}
