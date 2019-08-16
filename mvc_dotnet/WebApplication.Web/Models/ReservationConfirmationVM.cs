using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class ReservationConfirmationVM
    {
        public IList<Reservation> Reservations { get; set; }
        public string ConfirmationNumber { get; set; }
        public string FilmName { get; set; }
        public decimal TicketPrice { get; set; }
        public int RegularSeats { get; set; }
        public int SeniorSeats { get; set; }
        public int KidsSeats { get; set; }
        public decimal Total
        {
            get
            {
                decimal regular = RegularSeats * TicketPrice;
                decimal kids = KidsSeats * KidsTicketPrice;
                decimal senior = SeniorSeats * SeniorTicketPrice;
                decimal total = regular + kids + senior;
                return total;
            }
        }
        public decimal KidsTicketPrice
        {
            get
            {
                return (decimal).6 * TicketPrice;
            }
        }
        public decimal SeniorTicketPrice
        {
            get
            {
                return (decimal).9 * TicketPrice;
            }
        }
    }
}
