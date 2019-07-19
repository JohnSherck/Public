using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;

namespace Capstone.DAL
{
    public interface IReservationDAO
    {
        /// <summary>
        /// Get the reservations in a given Site
        /// </summary>
        /// <param name="siteId">The ID of the Site to show reservations for</param>
        /// <returns>List of Reservations</returns>
        List<Reservation> GetReservationsBySiteId(int siteId);

        List<Site>GetAvailableSites(DateTime start, DateTime end, int campGrId);

        /// <summary>
        /// Create a new reservation for given dates
        /// </summary>
        /// <param name="name">Name on the reservation</param>
        /// <param name="arrival">Date arriving at camp site</param>
        /// <param name="departure">Date leaving camp site</param>
        /// <returns>Reservation ID, or '0' if failed.</returns>
        int CreateReservation(int siteId, string name, DateTime arrival, DateTime departure, DateTime createdDate);
    }
}
