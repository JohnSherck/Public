using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.DAL
{
    public interface IReservationDAO
    {
        List<int> GetReservedSeatsForShowing(int showTimeID, DateTime movieDate);

        string CreateNewReservation(int showingId, List<int> chosenSeats, int userId, DateTime showingDate, int kidsTickets, int adultTickets, int seniorTickets);

        IList<Reservation> GetReservation(string confirmationNumber);
    }
}
