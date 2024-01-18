using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VetRepository
    {
        public List<Vet> GetAllVets()
        {
            List<Vet> results = new List<Vet>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from vets";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while(sqlDataReader.Read()) 
                {
                    Vet v = new Vet();
                    v.Id = sqlDataReader.GetInt32(0);
                    v.FullName = sqlDataReader.GetString(1);
                    v.Specialty = sqlDataReader.GetString(2);
                    v.YearsExperience = sqlDataReader.GetInt32(3);

                    results.Add(v);
                }
            }
            return results;
        }

        public int InsertVets(Vet v)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            { 
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("insert into vets values ('{0}','{1}','{2}')",
                    v.FullName, v.Specialty, v.YearsExperience);

                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int UpdateVets(Vet v)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE VETS SET FullName = '{0}', Specialty = '{1}', YearsExperience = {2} WHERE Id = {3}",
                    v.FullName, v.Specialty, v.YearsExperience, v.Id);

                return sqlCommand.ExecuteNonQuery();
            }
        }


        public int DeleteVets(Vet v)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM VETS WHERE Id = " + v.Id;

                return sqlCommand.ExecuteNonQuery();
            }
        }


    }
}
