using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.DAL
{
    public interface IShowTimeDAO
    {
        /// <summary>
        /// Get Showtimes for a given date
        /// </summary>
        /// <param name="viewingDate">The date to get showtimes for</param>
        /// <returns>list of ShowTimes</returns>
        List<FilmShowTime> GetAllShowtimes();

        string GetFilmName(int showTimeID);

        ///// <summary>
        ///// Get Showtimes for a given Film
        ///// </summary>
        ///// <param name="filmID">The ID of the film</param>
        ///// <returns>List of Showtimes for the film</returns>
        //List<ShowTime> GetShowtimesByFilmID(int filmID);

            /// <summary>
            /// Get the price for a particular show time
            /// </summary>
            /// <param name="showTimeID">The Id for a show time</param>
            /// <returns>The price for a regular ticket at that showtime</returns>
        decimal GetShowingPrice(int showTimeID);

    }
}
