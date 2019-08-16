using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class ShowTime
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int TheaterId { get; set; }
        public TimeSpan Showtime { get; set; }
        public decimal Price { get; set; }
    }
}
