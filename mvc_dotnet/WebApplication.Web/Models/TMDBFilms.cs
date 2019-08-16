using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class TMDBFilms
    {
        public TMDBFilm[] results { get; set; }
        public int page { get; set; }
        public int total_pages { get; set; }
    }
}
