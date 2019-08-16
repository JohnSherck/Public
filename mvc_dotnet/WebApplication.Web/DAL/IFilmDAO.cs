using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.DAL
{
    public interface IFilmDAO
    {
        /// <summary>
        /// retrieves all films with basic information for displaying a list of featured films
        /// </summary>
        /// <returns>Films to display</returns>
        List<Film> GetAllFilms();

        /// <summary>
        /// Retrieves a film with all information populated, for viewing the film detail
        /// </summary>
        /// <param name="filmID">The ID of the film to retrieve</param>
        /// <returns>Film details for a single film</returns>
        Film GetFilmByID(int filmID);

        /// <summary>
        /// Adds new film to database
        /// </summary>
        /// <param name="film">Film object created from API data</param>
        /// <returns>The newly created film's Id</returns>
        int AddNewFilmToDB(Film film);

        /// <summary>
        /// Updates a film's data in the database
        /// </summary>
        /// <param name="id">The film's id</param>
        /// <param name="title">The film's title</param>
        /// <param name="synopsis">A short description of the film</param>
        /// <param name="releaseDate">The film's release date</param>
        /// <param name="rating">Film's rating (R, G, PG-13, etc.)</param>
        /// <param name="runtime">Runtime of the film (min)</param>
        /// <param name="linkToSite">Link to the film's official site</param>
        /// <param name="imageLink">Link to a movie poster</param>
        /// <param name="startDate">The start of the film's running</param>
        /// <param name="endDate">The end of the film's running</param>
        void UpdateFilm(int id, string title, string synopsis, DateTime releaseDate, string rating, int runtime, string linkToSite, string imageLink, DateTime startDate, DateTime endDate);

        Film GetNextAvailableOpening();
    }
}
