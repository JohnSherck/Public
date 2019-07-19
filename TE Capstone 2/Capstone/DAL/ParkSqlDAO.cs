using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Capstone.Models;

namespace Capstone.DAL
{
    public class ParkSqlDAO : IParkDAO
    {
        private string connectionString;

        public ParkSqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public List<Park> GetAllParks()
        {
            // Create list to hold all parks
            List<Park> list = new List<Park>();

            try
            {
                // Create the connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "Select * from park";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // read each row
                    while (reader.Read())
                    {
                        //Create a new Park object from the reader row
                        Park obj = new Park();
                        obj.Park_Id = Convert.ToInt32(reader["Park_Id"]);
                        obj.Name = Convert.ToString(reader["name"]);
                        obj.Location = Convert.ToString(reader["Location"]);
                        obj.Establish_Date = Convert.ToDateTime(reader["Establish_Date"]);
                        obj.Area = Convert.ToInt32(reader["Area"]);
                        obj.Visitors = Convert.ToInt32(reader["Visitors"]);
                        obj.Description = Convert.ToString(reader["Description"]);
                        // Add created park to list
                        list.Add(obj);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"There was an error in GetAllParks: {ex.Message}");
            }
            // Return the list of parks
            return list;
        }
    }
}
