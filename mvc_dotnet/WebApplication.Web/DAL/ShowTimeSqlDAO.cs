using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.DAL
{
    public class ShowTimeSqlDAO : IShowTimeDAO
    {
        string ConnectionString;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="str">Connection String for the SQL database</param>
        public ShowTimeSqlDAO(string str)
        {
            this.ConnectionString = str;
        }

        List<FilmShowTime> IShowTimeDAO.GetAllShowtimes()
        {
            List<FilmShowTime> list = new List<FilmShowTime>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT s.showtime AS 'time', f.title AS 'title', f.id as 'filmId', 
                                        f.rating AS 'rating', s.price AS 'price', t.name AS 'screen' 
                                    FROM showtimes s JOIN theatres t ON s.theatreId = t.id JOIN films f ON t.id = f.screenId;";

                                    //showtimes s 
                                    //JOIN films f on f.id = s.filmId 
                                    //JOIN theatres t on s.theatreId = t.id;";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        FilmShowTime showtime = this.RowToFilmShowTime(reader);
                        list.Add(showtime);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return list;
        }

        //returns the ticket price for a showtimeID
        public decimal GetShowingPrice(int showTimeID)
        {
            decimal result = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT price FROM showtimes
                                    WHERE id = @id;";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", showTimeID);
                    result = Convert.ToDecimal (cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result;
        }

        public string GetFilmName(int showTimeID)
        {
            string result = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT f.title FROM films f JOIN theatres t ON f.screenId = t.id JOIN showtimes s ON t.id = s.theatreId WHERE s.Id = @id;";
                        //@"SELECT f.title FROM films f JOIN showtimes s 
                        //                on f.id = s.filmId WHERE s.id = @id;";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", showTimeID);
                    result = Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result;
        }

        //Maps a single database line into a FilmShowTime object
        private FilmShowTime RowToFilmShowTime(SqlDataReader reader)
        {
            FilmShowTime result = new FilmShowTime();

            result.Time = (TimeSpan)(reader["time"]);
            result.Title = Convert.ToString(reader["title"]);
            result.Rating = Convert.ToString(reader["rating"]);
            result.Screen = Convert.ToString(reader["screen"]);
            result.Price = Convert.ToDecimal(reader["price"]);
            result.FilmId = Convert.ToInt32(reader["filmId"]);
            return result;

        }
    }
}
