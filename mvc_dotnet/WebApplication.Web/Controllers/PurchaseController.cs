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
    public class PurchaseController : Controller
    {
        private IReservationDAO ResDAO;
        private IFilmDAO FilmDAO;
        private IShowTimeDAO ShowTimeDAO;
        private IAuthProvider authProvider;
        private IUserDAL userDAO;
        public PurchaseController(IReservationDAO resParam, IFilmDAO filmParam, IShowTimeDAO stParam, IAuthProvider authProvider, IUserDAL userDAO)
        {
            this.ResDAO = resParam;
            this.FilmDAO = filmParam;
            this.ShowTimeDAO = stParam;
            this.authProvider = authProvider;
            this.userDAO = userDAO;
        }

        //Tell us how many seniors, minors, adults
        [AuthorizationFilter]
        public IActionResult Tickets(PurchaseFlowVM vm)
        {
            vm.ClosedSeats = this.ResDAO.GetReservedSeatsForShowing(vm.ShowTimeID, vm.MovieDate);
            //get the ticket price for view
            vm.RegularTicketPrice = this.ShowTimeDAO.GetShowingPrice(vm.ShowTimeID);
            return View(vm); //known: closedSeats, showTimeID, movieDate
        }


        //View available seats for the given ShowTime
        [AuthorizationFilter]
        [HttpPost]
        public IActionResult Seats(PurchaseFlowVM vm) //must pass in showTimeID and movieDate
        {
            vm.ClosedSeats = this.ResDAO.GetReservedSeatsForShowing(vm.ShowTimeID, vm.MovieDate);

            ////get the FilmName
            //vm.FilmName = this.ShowTimeDAO.GetFilmName(vm.ShowTimeID);
            //vm.RegularTicketPrice = this.ShowTimeDAO.GetShowingPrice(vm.ShowTimeID);

            return View(vm); //known: closedSeats, showTimeID, movieDate, RegularSeats, KidSeats, SeniorSeats
        }

        [AuthorizationFilter]
        [HttpGet]
        public IActionResult Checkout(PurchaseFlowVM vm, string ChosenSeatsAsString) //Now the ticket types and counts are known
        {
            // Need to get prices from DB and set them on our view model
            vm.RegularTicketPrice = this.ShowTimeDAO.GetShowingPrice(vm.ShowTimeID);
            vm.CurrentUser = authProvider.GetCurrentUser();
            return View(vm);
        }

        [AuthorizationFilter]
        [HttpPost]
        public IActionResult Checkout(PurchaseFlowVM vm)
        {
            string confirmationNum = "";
            TempData["showtimeId"] = vm.ShowTimeID;
            TempData["Total"] = vm.Total;
            TempData["Kid"] = vm.KidsSeats;
            TempData["Adult"] = vm.RegularSeats;
            TempData["Senior"] = vm.SeniorSeats;
            //if (vm.CurrentUser.Address == null)
            //{
            //    vm.CurrentUser = authProvider.GetCurrentUser();
            //    //userDAO.UpdateUser(vm.CurrentUser, vm.CurrentUser.FirstName, vm.CurrentUser.LastName, vm.CurrentUser.City, vm.CurrentUser.State, vm.CurrentUser.Zip, vm.CurrentUser.Address, vm.CurrentUser.Email)
            //}
            //else
            //{
            vm.CurrentUser = authProvider.GetCurrentUser();
            //}
            confirmationNum = ResDAO.CreateNewReservation(vm.ShowTimeID, vm.ChosenSeats, vm.CurrentUser.Id, vm.MovieDate, vm.KidsSeats, vm.RegularSeats, vm.SeniorSeats);

            TempData["confNum"] = confirmationNum;
            return RedirectToAction("Confirmation", "Purchase");

        }
        [AuthorizationFilter]
        public IActionResult Confirmation(ReservationConfirmationVM vm)
        {
            string confNum = (string)TempData["confNum"];
            int showtimeId = (int)TempData["showtimeId"];
            vm.KidsSeats = (int)TempData["Kid"];
            vm.RegularSeats = (int)TempData["Adult"];
            vm.SeniorSeats = (int)TempData["Senior"];
            vm.FilmName = ShowTimeDAO.GetFilmName(showtimeId);
            vm.Reservations = ResDAO.GetReservation(confNum);
            vm.ConfirmationNumber = confNum;
            vm.TicketPrice = ShowTimeDAO.GetShowingPrice(showtimeId);
            return View(vm);
        }

    }
}