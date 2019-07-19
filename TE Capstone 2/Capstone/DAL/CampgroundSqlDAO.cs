using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Capstone.Models;

namespace Capstone.DAL
{
    public class CampgroundSqlDAO : ICampgroundDAO
    {
        private string connectionString;

        public CampgroundSqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public List<Campground> GetCampgroundsByParkId(int parkId)
        {
            // Create list to hold all campgrounds
            List<Campground> list = new List<Campground>();

            try
            {
                // Create the connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "Select * from campground where park_id = @parkId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@parkId", parkId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // read each row
                    while (reader.Read())
                    {
                        //Create a new object from the reader row
                        Campground obj = new Campground();
                        obj.Campground_Id = Convert.ToInt32(reader["Campground_Id"]);
                        obj.Park_Id = Convert.ToInt32(reader["Park_Id"]);
                        obj.Name = Convert.ToString(reader["name"]);
                        obj.Open_From_Mm = Convert.ToInt32(reader["Open_From_Mm"]);
                        obj.Open_To_Mm = Convert.ToInt32(reader["Open_To_Mm"]);
                        obj.Daily_Fee = Convert.ToDecimal(reader["Daily_Fee"]);
                        // Add the campground to the list
                        list.Add(obj);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"There was an error in GetCampgroundsByParkId: {ex.Message}");
            }
            // Return the list of campgrounds
            return list;
        }
    }
}
