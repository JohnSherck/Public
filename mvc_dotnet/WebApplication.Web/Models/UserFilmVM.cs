using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class UserFilmVM
    {
        public User CurrentUser { get; set; }
        public IList<Film> FilmList { get; set; }
    }
}
