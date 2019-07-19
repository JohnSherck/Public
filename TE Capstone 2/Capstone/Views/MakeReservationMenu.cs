using System;
using System.Collections.Generic;
using System.Text;
using Capstone.DAL;
using Capstone.Models;

namespace Capstone.Views
{
    public class MakeReservationMenu : CLIMenu
    {

        private IReservationDAO reservationDAO;
        private Campground Campground;
        private DateTime Arrival;
        private DateTime Departure;
        private List<Site> AvailableSites;
        // Tracks whether any available sites were found for the given dates; used to manage menus.
        public bool FoundReservations;

        public MakeReservationMenu(IReservationDAO resDaoParam, Campground campground, DateTime arrival, DateTime departure)
            : base()
        {
            this.reservationDAO = resDaoParam;
            this.Campground = campground;
            this.Arrival = arrival;
            this.Departure = departure;
            this.AvailableSites = reservationDAO.GetAvailableSites(arrival, departure, this.Campground.Campground_Id);

            this.Title = "Results matching your search criteria:";
            // This if statement displays a message letting the user know that no sites were found and sets 
            // the "FoundReservations" property to false.
            if (this.AvailableSites.Count == 0)
            {
                this.FoundReservations = false;
                Console.WriteLine("Unfortunately, all sites at that campground are booked during your requested dates.");
                Console.WriteLine("Please select from one of our other amazing campgrounds.");
                Pause("");

            }
            else
            {
                this.FoundReservations = true;
                foreach (Site site in this.AvailableSites)
                {
                    //creates strings to hold a yes/no value for the two boolean fields
                    string accessible = site.Accessible ? "Yes" : "No";
                    string utilities = site.Utilities ? "Yes" : "No";
                    this.menuOptions.Add(site.Site_Number.ToString("00"),
                        $"     {site.Max_Occupancy,-14} {accessible,-15}{site.Max_Rv_Length,-15}{utilities,-9}" +
                        $"{this.Campground.Daily_Fee * (departure - arrival).Days,7:C}");
                }
            }
            this.menuOptions.Add("Q", " ");
            Console.WriteLine();


        }

        protected override void DisplayBeforeMenu()
        {
            if (menuOptions.Count != 1)
            {
                Console.WriteLine("Site No.".PadRight(10) + "Max Occup.".PadRight(15) + "Accessible?".PadRight(15) + "Max RV Length".PadRight(15) + "Utility".PadRight(10) + "Cost");
            }

        }

        protected override void DisplayAfterMenu()
        {
            if (menuOptions.Count != 1)
            {

                Console.WriteLine("Which site number would you like to reserve (enter Q to cancel)? ");
            }
        }

        protected override bool ExecuteSelection(string choice)
        {
            int choiceInt = -1;
            if (int.TryParse(choice, out choiceInt))
            {
                if (this.menuOptions.ContainsKey(choice))
                {
                    string name = "";
                    Console.Write("What name should the reservation be made under? ");
                    name = Console.ReadLine();
                    int reservationId = this.reservationDAO.CreateReservation(choiceInt, name, this.Arrival, this.Departure, DateTime.Now);
                    Console.WriteLine($"The reservation has been made and the confirmation ID is {reservationId}.");
                    Console.ReadLine();
                }
            }


            return false;

        }

    }
}
