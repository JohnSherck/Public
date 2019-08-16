using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class Film
    {
      
        public int Id { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public string Synopsis { get; set; }
        public string ImageLink { get; set; }
        public string Rating { get; set; }
        public List<string> Genre { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<ShowTime> Showings { get; set; }
        public string LinkToSite { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int ScreenId { get; set; }

        public Film()
        {
            //avoid null properties
            this.Actors = new List<string>();
            this.Genre = new List<string>();
            this.ReleaseDate = new DateTime();
            this.Showings = new List<ShowTime>();
        }

    }
}
