using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public class SurveyResultSqlDAO : ISurveyResultDAO
    {
        private readonly string connectionString;
        public SurveyResultSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<FavoriteParksVM> GetFavoriteParks()
        {
            List<FavoriteParksVM> output = new List<FavoriteParksVM>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"select count(*) as 'Count', p.parkName as 'Name', p.parkCode as 'ParkCode' from survey_result as s " +
                        "join park as p on s.parkCode = p.parkCode group by p.parkName, p.parkCode " +
                        "order by count(*) desc, p.parkName asc";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        FavoriteParksVM vm = RowToObject(reader);
                        output.Add(vm);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }

        private FavoriteParksVM RowToObject(SqlDataReader reader)
        {
            FavoriteParksVM vm = new FavoriteParksVM();
            vm.ParkName = Convert.ToString(reader["Name"]);
            vm.SurveyCount = Convert.ToInt32(reader["Count"]);
            vm.ParkCode = Convert.ToString(reader["ParkCode"]);
            return vm;
        }

        public void SaveSurveyResult(SurveyResult result)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"INSERT INTO survey_result VALUES (@parkCode, @email, @state, @activity)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.Parameters.AddWithValue("@parkCode", parkCode);
                    cmd.Parameters.AddWithValue("@parkCode", result.ParkCode);
                    cmd.Parameters.AddWithValue("@email", result.Email);
                    cmd.Parameters.AddWithValue("@state", result.State);
                    cmd.Parameters.AddWithValue("@activity", result.ActivityLevel);

                    cmd.ExecuteScalar();

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

        }
    }
}
