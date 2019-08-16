using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    /// <summary>
    /// A Class for pairing showtime info with basic film info, for easily displaying on frontend
    /// </summary>
    public class FilmShowTime
    {
        public TimeSpan Time { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public decimal Price { get; set; }
        public string Screen { get; set; }
        public int FilmId { get; set; }
    }
}
