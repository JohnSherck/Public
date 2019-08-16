using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.DAL
{
    public class ReservationSqlDAO : IReservationDAO
    {
        private string ConnectionString;
        public ReservationSqlDAO(string connStringParam)
        {
            this.ConnectionString = connStringParam;
        }

        /// <summary>
        /// Retrieve a list of seats that are already reserved
        /// </summary>
        /// <param name="showTimeID">The ID of the showtime being examined</param>
        /// <param name="movieDate">The Date of the showing being examined</param>
        /// <returns>List of integer seat identifiers</returns>
        public List<int> GetReservedSeatsForShowing(int showTimeID, DateTime movieDate)
        {
            List<int> result = new List<int>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT * FROM reservations 
                                    WHERE showingId = @id
                                    AND date = @date";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", showTimeID);
                    cmd.Parameters.AddWithValue("@date", movieDate.Date);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //add the reserved seat to the list
                        result.Add(Convert.ToInt32(reader["seatId"]));
                    }
                  
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result;
        }
        /// <summary>
        /// Gets a list of reservations for a particular confirmation number
        /// </summary>
        /// <param name="confirmationNumber">The order's confirmation number</param>
        /// <returns></returns>
        public IList<Reservation> GetReservation(string confirmationNumber)
        {
            IList<Reservation> reservationList = new List<Reservation>();
            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM reservations WHERE confirmNum = @confirmNum;";

                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@confirmNum", confirmationNumber);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Reservation res = new Reservation();
                        res.Id = Convert.ToInt32(reader["id"]);
                        res.ShowingID = Convert.ToInt32(reader["showingId"]);
                        res.Date = Convert.ToDateTime(reader["date"]);
                        res.SeatID = Convert.ToInt32(reader["seatId"]);
                        res.UserID = Convert.ToInt32(reader["userId"]);
                        res.ConfirmNum = Convert.ToString(reader["confirmNum"]);
                        reservationList.Add(res);
                    }

                    
                    return reservationList;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserts a new reservation into the database
        /// </summary>
        /// <param name="showingId">The id of the showtime</param>
        /// <param name="chosenSeats">An array of the users chosen seats</param>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
        public string CreateNewReservation(int showingId, List<int>chosenSeats, int userId, DateTime showingDate, int kidsTickets, int adultTickets, int seniorTickets)
        {
            string confirmationNum = $"{userId}" + $"{showingId}" + $"{showingDate.Date.Month}" + $"{showingDate.Date.Day}" + $"{showingDate.Date.Year}";
            foreach (int seat in chosenSeats)
            {
                confirmationNum = confirmationNum + $"-{seat}";
            }
            if (kidsTickets > 10)
            {
                confirmationNum = confirmationNum + $"-{kidsTickets}" + $"0{adultTickets}" + $"0{seniorTickets}";
            }
            else if (adultTickets > 10)
            {
                confirmationNum = confirmationNum + $"-0{kidsTickets}" + $"{adultTickets}" + $"0{seniorTickets}";
            }
            else if (seniorTickets > 10)
            {
                confirmationNum = confirmationNum + $"-0{kidsTickets}" + $"0{adultTickets}" + $"{seniorTickets}";
            }
            else
            {
                confirmationNum = confirmationNum + $"-0{kidsTickets}" + $"0{adultTickets}" + $"0{seniorTickets}";
            }
            try
            {
                using(SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    foreach (int seat in chosenSeats)
                    {
                        string sql = "INSERT INTO reservations (showingId, date, seatId, userId, confirmNum)" +
                            "                            VALUES(@showingId, @date, @seatId, @userId, @confirmNum); SELECT @@Identity";

                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@showingId", showingId);
                        cmd.Parameters.AddWithValue("@date", showingDate);
                        cmd.Parameters.AddWithValue("@seatId", seat);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@confirmNum", confirmationNum);
                        cmd.ExecuteNonQuery();

                    }
                        return confirmationNum;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        
    }
}
