using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Web.DAL;
using WebApplication.Web.Models;
using WebApplication.Web.Models.Account;
using WebApplication.Web.Providers.Auth;

namespace WebApplication.Web.Controllers
{    
    public class AccountController : Controller
    {
        private readonly IAuthProvider authProvider;
        private readonly IUserDAL userDAO;
        public AccountController(IAuthProvider authProvider, IUserDAL userDAO)
        {
            this.userDAO = userDAO;
            this.authProvider = authProvider;
        }
        
        //[AuthorizationFilter] // actions can be filtered to only those that are logged in
        [AuthorizationFilter("Admin", "Author", "Manager", "User")]  //<-- or filtered to only those that have a certain role
        [HttpGet]
        public IActionResult Index()
        {
            var user = authProvider.GetCurrentUser();
            return View(user);
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            var currentUser = authProvider.GetCurrentUser();
            if (user.FirstName == null) user.FirstName = "";
            if (user.LastName == null) user.LastName = "";
            if (user.City == null) user.City = "";
            if (user.State == null) user.State = "";
            if (user.Zip == null) user.Zip = "";
            if (user.Address == null) user.Address = "";
            if (user.Email == null) user.Email = "";

            userDAO.UpdateUser(currentUser, user.FirstName, user.LastName, user.City, user.State, user.Zip, user.Address, user.Email);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            // Ensure the fields were filled out
            if (ModelState.IsValid)
            {
                // Check that they provided correct credentials
                bool validLogin = authProvider.SignIn(loginViewModel.Email, loginViewModel.Password);
                if (validLogin)
                {
                    // Redirect the user where you want them to go after successful login
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(loginViewModel);
        }
        
        [HttpGet]
        public IActionResult LogOff()
        {
            // Clear user from session
            authProvider.LogOff();

            // Redirect the user where you want them to go after logoff
            return RedirectToAction("Index", "Home");
        }
        
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {            
            if (ModelState.IsValid)
            {
                // Register them as a new user (and set default role)
                // When a user registeres they need to be given a role. If you don't need anything special
                // just give them "User".
                authProvider.Register(registerViewModel.Email, registerViewModel.Password, role: "User"); 

                // Redirect the user where you want them to go after registering
                return RedirectToAction("Index", "Home");
            }
            return View(registerViewModel);
        }

    }
}