using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.DAL
{
    public class FilmSqlDAO : IFilmDAO
    {
        string ConnectionString;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="str">Connection String for the SQL database</param>
        public FilmSqlDAO(string str)
        {
            this.ConnectionString = str;
        }

        public List<Film> GetAllFilms()
        {
            DateTime today = DateTime.Now;
            DateTime maxDate = today.AddDays(7);


            List<Film> list = new List<Film>();
            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    // WHERE startDate >= @today AND endDate <= @maxDate;
                    string sql = @"SELECT f.*, d.name AS directorName from films f
                                        LEFT JOIN director d on f.directorId  = d.Id
                                        WHERE (f.startDate <= GETDATE()+6 AND f.endDate > GETDATE())
                                    Select * from showtimes;";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.Parameters.AddWithValue("@today", today);
                    //cmd.Parameters.AddWithValue("@maxDate", maxDate);
                    SqlDataReader reader = cmd.ExecuteReader();
                    


                    while (reader.Read())
                    {
                        Film film = this.RowToFilm(reader);
                        list.Add(film);
                    }
                    reader.NextResult();

                    while (reader.Read())
                    {
                        ShowTime st = new ShowTime();
                        st.Id = Convert.ToInt32(reader["id"]);
                        //st.FilmId = Convert.ToInt32(reader["filmid"]);
                        st.Price = Convert.ToDecimal(reader["price"]);
                        st.Showtime = (TimeSpan)(reader["showtime"]);
                        st.TheaterId = Convert.ToInt32(reader["theatreId"]);

                        foreach(Film film in list)
                        {
                            if (film.ScreenId == st.TheaterId)
                            {
                                film.Showings.Add(st);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return list;
        }

        public void UpdateFilm(int id, string title, string synopsis, DateTime releaseDate, string rating, int runtime, string linkToSite, string imageLink, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    Film film = GetFilmByID(id);
                    string sql = @"UPDATE films SET
                                   title = @title,
                                   synopsis = @synopsis,
                                   releaseDate = @releaseDate,
                                   rating = @rating,
                                   runtime = @runtime,
                                   linkToSite = @linkToSite,
                                   imageLink = @imageLink,
                                   startDate = @startDate,
                                   endDate = @endDate
                                   WHERE films.id = @id;";
                                                    
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", film.Id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@synopsis", synopsis);
                    cmd.Parameters.AddWithValue("@releaseDate", releaseDate);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@runtime", runtime);
                    cmd.Parameters.AddWithValue("@linkToSite", linkToSite);
                    cmd.Parameters.AddWithValue("@imageLink", imageLink);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Film GetFilmByID(int filmID)
        {
            Film result = new Film();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT f.*, d.name AS directorName from films f 
                                       LEFT JOIN director d on f.directorId  = d.Id
                                            WHERE f.id = @id; 
                                    SELECT * FROM actors a 
	                                    LEFT JOIN actor_film af on a.id = af.actorId
	                                    WHERE af.filmId = @id;
                                    SELECT g.title FROM films f JOIN film_genre fg
		                                ON fg.filmId = f.id LEFT JOIN genre g 
		                                ON g.id = fg.genreId
		                                WHERE f.id = @id;
                                   SELECT * FROM showtimes s JOIN theatres t ON s.theatreId = t.id JOIN films f ON t.id = f.screenId WHERE f.id = @id;";

                                 //   SELECT * from showtimes WHERE filmId = @id;";       //add genre query and showings query
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", filmID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    //read one result, for 1 film
                    if (reader.Read())
                    {
                        result = this.RowToFilm(reader);                        
                    }

                    //Now read the result set from actors
                    reader.NextResult();
                    while (reader.Read())
                    {
                        result.Actors.Add(Convert.ToString(reader["name"]));
                    }

                    //Now read the result set from genre
                    reader.NextResult();
                    while (reader.Read())
                    {
                        result.Genre.Add(Convert.ToString(reader["title"]));
                    }

                    //Now read the result set from showings
                    reader.NextResult();
                    while (reader.Read())
                    {
                        ShowTime showTime = new ShowTime();

                        showTime.Id = Convert.ToInt32(reader["Id"]);
                        //showTime.FilmId = Convert.ToInt32(reader["filmId"]);
                        showTime.TheaterId = Convert.ToInt32(reader["theatreId"]);
                        showTime.Showtime = (TimeSpan)(reader["showtime"]);
                        showTime.Price = Convert.ToDecimal(reader["price"]);

                        result.Showings.Add(showTime);                        
                    }

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result;
        }

        private Film RowToFilm(SqlDataReader reader)
        {
            Film result = new Film();

            result.Id = Convert.ToInt32(reader["id"]);
            result.Title = Convert.ToString(reader["title"]);
            result.Synopsis = Convert.ToString(reader["synopsis"]);
            result.ReleaseDate = Convert.ToDateTime(reader["releaseDate"]);
            result.Rating = Convert.ToString(reader["rating"]);
            result.RunTime = Convert.ToInt32(reader["runtime"]);
            result.LinkToSite = Convert.ToString(reader["linkToSite"]);
            result.ImageLink = Convert.ToString(reader["imageLink"]);
            result.Director = Convert.ToString(reader["directorName"]);
            result.startDate = Convert.ToDateTime(reader["startDate"]);
            result.endDate = Convert.ToDateTime(reader["endDate"]);
            result.ScreenId = Convert.ToInt32(reader["screenId"]);
            return result;
        }

        public int AddNewFilmToDB(Film film)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO films (title, synopsis, releaseDate, runtime, imageLink, startDate, endDate, screenID)
                                    VALUES (@title, @synopsis, @releaseDate, @runtime, @imageLink, @startDate, @endDate, @screenID); Select @@Identity;";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", film.Title);
                    cmd.Parameters.AddWithValue("@synopsis", film.Synopsis);
                    cmd.Parameters.AddWithValue("@releaseDate", film.ReleaseDate);
                    cmd.Parameters.AddWithValue("@runtime", film.RunTime);
                    cmd.Parameters.AddWithValue("@imageLink", film.ImageLink);
                    cmd.Parameters.AddWithValue("@startDate", film.startDate);
                    cmd.Parameters.AddWithValue("@endDate", film.endDate);
                    cmd.Parameters.AddWithValue("@screenID", film.ScreenId);


                    int filmId = Convert.ToInt32(cmd.ExecuteScalar());
                    return filmId;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        
        public Film GetNextAvailableOpening()
        {
            Film result = new Film();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT f.id, f.title, s.theatreId, f.startDate, f.endDate from films f
		                            JOIN showtimes s on s.theatreId = f.screenID
		                            WHERE f.endDate NOT IN(SELECT startDate FROM films)
		                            GROUP BY f.id, title, s.theatreId, startDate, endDate
		                            ORDER BY endDate asc";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) //the first line is all we need
                    {
                        result.startDate = (DateTime)reader["endDate"];     //the soonest open endDate will be the new startDate
                        result.endDate = result.startDate.AddDays(21);
                        result.ScreenId = (int)reader["theatreid"];
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result;
        }

    }
}
