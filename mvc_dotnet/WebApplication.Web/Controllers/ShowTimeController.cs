using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Web.DAL;
using WebApplication.Web.Models;
using WebApplication.Web.Providers.Auth;

namespace WebApplication.Web.Controllers
{
    public class ShowTimeController : Controller
    {
        private IShowTimeDAO showDAO;
        private IFilmDAO filmDAO;
        private IAuthProvider authProvider;

        public ShowTimeController(IShowTimeDAO showDAO, IFilmDAO filmDAO, IAuthProvider authProvider)
        {
            this.showDAO = showDAO;
            this.filmDAO = filmDAO;
            this.authProvider = authProvider;
        }

        public IActionResult Index()
        {
            UserFilmVM vm = new UserFilmVM();
            vm.FilmList = filmDAO.GetAllFilms();
            vm.CurrentUser = authProvider.GetCurrentUser();
            return View(vm);
        }
    }
}