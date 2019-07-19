using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using System.Data.SqlClient;

namespace Capstone.DAL
{
    public class ReservationSqlDAO :IReservationDAO
    {
        private string connectionString;
        /// <summary>
        /// Costructor
        /// </summary>
        /// <param name="databaseconnectionString">Database Connection String</param>
        public ReservationSqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        /// <summary>
        /// When a user wants to book a campsite for a stay, this method checks their
        /// request against campsite availablity
        /// </summary>
        /// <param name="start">Start date of user's planned reservation</param>
        /// <param name="end">End date of user's planned reservation</param>
        /// <param name="campGrId">Campground ID to search</param>
        /// <returns></returns>
        public List<Site> GetAvailableSites(DateTime start, DateTime end, int campGrId)
        {
            // Initialize a list to hold the available sites
            List<Site> list = new List<Site>();

            try
            {
                // Open SQL connection
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    //Create the query to select all sites in the requested campground
                    //for which there is NOT a reservation
                    string sql = "SELECT * from site where site_id not in " +
                        "(select site_id from reservation where site_id in " +
                        "(SELECT site_id from site WHERE campground_id = @campGroundId) " +
                        "and (from_date between @startDate " +
                        "and @endDate or to_date between @startDate and @endDate or @startDate between from_Date and to_Date)) " +
                        "and campground_id = @campGroundId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@startDate", start.Date);
                    cmd.Parameters.AddWithValue("@endDate", end.Date);
                    cmd.Parameters.AddWithValue("@campGroundId", campGrId);
                    // Open a reader
                    SqlDataReader reader = cmd.ExecuteReader();

                    // read each row
                    while (reader.Read())
                    {
                        //Create a new object from the reader row
                        Site obj = new Site();
                        obj.Site_Id = Convert.ToInt32(reader["site_Id"]);
                        obj.Campground_Id = Convert.ToInt32(reader["Campground_Id"]);
                        obj.Site_Number = Convert.ToInt32(reader["Site_Number"]);
                        obj.Max_Occupancy = Convert.ToInt32(reader["Max_Occupancy"]);
                        obj.Accessible = Convert.ToBoolean(reader["Accessible"]);
                        obj.Max_Rv_Length = Convert.ToInt32(reader["Max_Rv_Length"]);
                        obj.Utilities = Convert.ToBoolean(reader["Utilities"]);
                        // Add the site to the list
                        list.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting availble sites by dates: " + ex.Message);
                Console.ReadLine();
            }
            // Return the list of sites
            return list;
        }
        /// <summary>
        /// Takes user input to create a new reservation (data has already been checked
        /// for camp site availability)
        /// </summary>
        /// <param name="siteId">User has selected site from available sites</param>
        /// <param name="name">Name entered for the reservation</param>
        /// <param name="arrival">Date user will arrive</param>
        /// <param name="departure">Date user will depart</param>
        /// <param name="createdDate">Date reservation was made, generated automatically</param>
        /// <returns></returns>
        public int CreateReservation(int siteId, string name, DateTime arrival, DateTime departure, DateTime createdDate)
        {
            try
            {
                // Open connection
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    //Create the query to insert a Reservation
                    string sql = "INSERT INTO reservation (Site_Id,name,from_date,To_Date,Create_Date) VALUES " +
                        "(@siteID, @name, @from, @to, @created); SELECT @@IDENTITY as 'Identity'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@siteid", siteId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@from", arrival);
                    cmd.Parameters.AddWithValue("@to", departure);
                    cmd.Parameters.AddWithValue("@created", createdDate);

                    //Add the line into the DB and return the ID
                    return Convert.ToInt32 ( cmd.ExecuteScalar() ) ;                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting reservations for site: " + ex.Message);
            }

            //failure code
            return 0;
        }

        public List<Reservation> GetReservationsBySiteId(int siteId)
        {
            //Create a list to hold all of the Reservations associated with the given Site
            List<Reservation> list = new List<Reservation>();

            try
            {
                using(SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    //Create the query to get all Reservations with the siteID
                    string sql = "SELECT * FROM reservation WHERE site_id = @siteid";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@siteid", siteId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    //read all the rows
                    while (reader.Read())
                    {
                        //Create a new Reservation from the row
                        Reservation obj = new Reservation();
                        obj.Reservation_Id = Convert.ToInt32(reader["Reservation_Id"]);
                        obj.Site_Id = Convert.ToInt32(reader["Site_Id"]);
                        obj.Name = Convert.ToString(reader["name"]);
                        obj.From_Date = Convert.ToDateTime(reader["from_date"]);
                        obj.To_Date = Convert.ToDateTime(reader["To_Date"]);
                        obj.Create_Date = Convert.ToDateTime(reader["Create_Date"]);

                        //Add the fully mapped Reservation to the list
                        list.Add(obj);
                    }
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting reservations for site: " + ex.Message);
            }
            return list;
        }
    }
}
