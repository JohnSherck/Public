using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Web.DAL;
using WebApplication.Web.Models;
using WebApplication.Web.Providers.Auth;

namespace WebApplication.Web.Controllers
{
    public class AdminController : Controller
    {
        private IFilmDAO filmDAO;

        #region API Stuff - Properties and Methods
        private HttpClient client;

        private async Task<TMDBFilm> GetFilmAsync(string path)
        {
            TMDBFilm film = null;   //variable to store results
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                //string s = await response.Content.ReadAsStringAsync();
                film = await response.Content.ReadAsAsync<TMDBFilm>();
            }
            return film;
        }

        private async Task<TMDBFilms> GetFilmsAsync(string path)
        {
            TMDBFilms films = null;   //variable to store results
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                //string s = await response.Content.ReadAsStringAsync();
                films = await response.Content.ReadAsAsync<TMDBFilms>();
            }
            return films;
        }
        #endregion

        public AdminController(IFilmDAO filmDAOParam)
        {
            this.filmDAO = filmDAOParam;

            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("https://api.themoviedb.org/3/");
            this.client.DefaultRequestHeaders.Accept.Clear();
            this.client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }




        [AuthorizationFilter("Admin")]
        public IActionResult Success(int id)
        {
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");         
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult AddNewFilm(/*List<Film> films*/)
        {
            //get set of films from the API
            TMDBFilms films = GetFilmsAsync("https://api.themoviedb.org/3/discover/movie?primary_release_date.gte=2019-06-01&primary_release_date.lte=2019-08-13&original_language=en&adult=false&page=1&api_key=9173523d02b5d500a3d9252ff424f79b").Result;

            //Map to a Model the View is expecting
            IList<Film> vm = TMDBsToFilms(films);

            return View(vm);
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult AddNewFilm(int id)
        {
            //POST - REDIRECT - GET
            return RedirectToAction("NewFilm", new {id = id });
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult NewFilm(int id)
        {
            string path = "https://api.themoviedb.org/3/movie/" + id.ToString() + "?&api_key=9173523d02b5d500a3d9252ff424f79b";
            TMDBFilm apiFilm = GetFilmAsync(path).Result;
            Film vm = TMDBtoFilm(apiFilm);
            
            Film temp = this.filmDAO.GetNextAvailableOpening(); //populate film next available start date, and screen ID
            vm.startDate = temp.startDate;
            vm.endDate = temp.endDate;
            vm.ScreenId = temp.ScreenId;
            

            return View(vm);
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult NewFilm(Film film)
        {
            string path = "https://api.themoviedb.org/3/movie/" + film.Id.ToString() + "?&api_key=9173523d02b5d500a3d9252ff424f79b";
            TMDBFilm apiFilm = GetFilmAsync(path).Result;
            Film vm = TMDBtoFilm(apiFilm);

            Film temp = this.filmDAO.GetNextAvailableOpening(); //populate film next available start date, and screen ID
            vm.startDate = temp.startDate;
            vm.endDate = temp.endDate;
            vm.ScreenId = temp.ScreenId;

            int filmId = filmDAO.AddNewFilmToDB(vm);

            return RedirectToAction("Index");
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult EditFilm(int id)
        {
            Film film = filmDAO.GetFilmByID(id);
            return View(film);
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult EditFilm(Film film)
        {
            filmDAO.UpdateFilm(film.Id, film.Title, film.Synopsis, film.ReleaseDate, film.Rating, film.RunTime, film.LinkToSite, film.ImageLink, film.startDate, film.endDate);
            return RedirectToAction("Success", "Admin");
        }


        /// <summary>
        /// Convert a set of TMDB film results into a list of Films
        /// </summary>
        /// <param name="filmsParam">information populated by an API call, in TMDBFilms format</param>
        /// <returns>List of Films corresponding to the data in the TMDBFilms.results property</returns>
        private List<Film> TMDBsToFilms(TMDBFilms filmsParam) {
            List<Film> result = new List<Film>();

            foreach(TMDBFilm tmdbFilm in filmsParam.results)
            {
                Film film = TMDBtoFilm(tmdbFilm);
                result.Add(film);
            }

            return result;
        }

        /// <summary>
        /// Map a single TMDBfilm to a Film
        /// </summary>
        /// <param name="Data on a single film, from the API"></param>
        /// <returns>Film populated with the data from the API</returns>
        private Film TMDBtoFilm(TMDBFilm tmdbFilm)
        {
            Film result = new Film();
            result.Title = tmdbFilm.title;
            result.Synopsis = tmdbFilm.overview;
            result.ImageLink = tmdbFilm.fullPosterPath;
            result.Id = tmdbFilm.id;
            result.ReleaseDate = Convert.ToDateTime(tmdbFilm.release_date);
            result.RunTime = tmdbFilm.runtime;
            if(tmdbFilm.genres != null)
            {
                foreach(Genre genre in tmdbFilm.genres)
                {
                    result.Genre.Add(genre.name);
                }
            }

            return result;
        }
    }
}