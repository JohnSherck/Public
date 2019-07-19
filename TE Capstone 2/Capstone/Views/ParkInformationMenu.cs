using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using Capstone.DAL;

namespace Capstone.Views
{
    public class ParkInformationMenu : CLIMenu
    {
        private ICampgroundDAO campgroundDAO;
        private IReservationDAO reservationDAO;
        private Park park;
        public ParkInformationMenu(ICampgroundDAO campground, IReservationDAO reservation, Park park) : base()
        {
            this.campgroundDAO = campground;
            this.reservationDAO = reservation;
            this.park = park;


            this.Title = "Park Information Screen";
            this.menuOptions.Add("1", "View Campgrounds to Search for Reservation");
            this.menuOptions.Add("Q", "Return to Main Menu");
        }

        protected override void DisplayBeforeMenu()
        {
            string location = "Location:";
            string established = "Established:";
            string area = "Area:";
            string annualVisitors = "Annual Visitors:";
            base.DisplayBeforeMenu();
            Console.WriteLine($"{park.Name}");
            Console.WriteLine($"{location, -18} {park.Location}");
            Console.WriteLine($"{established,-18} {park.Establish_Date.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"{area,-18} {park.Area.ToString("N0")} sq km");
            Console.WriteLine($"{annualVisitors,-18} {park.Visitors.ToString("N0")}");
            Console.WriteLine();
            Console.WriteLine($"{park.Description}");

        }

        protected override bool ExecuteSelection(string choice)
        {
            switch (choice)
            {
                case "1":
                    SearchReservationMenu menu = new SearchReservationMenu(this.park.Park_Id, this.reservationDAO, this.campgroundDAO);
                    menu.Run();

                    
                    return false;
            }
            


            Console.WriteLine("Invalid input, press any key to try again.");
            Console.ReadKey();
            return true;




         
        }

    }
}
