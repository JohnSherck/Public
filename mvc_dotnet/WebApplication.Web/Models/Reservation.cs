using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ShowingID { get; set; }
        public DateTime Date { get; set; }
        public int SeatID { get; set; }
        public int UserID { get; set; }
        public string ConfirmNum { get; set; }
    }
}
