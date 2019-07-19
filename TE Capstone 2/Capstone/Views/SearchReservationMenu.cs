using Capstone.DAL;
using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Capstone.Views
{
    public class SearchReservationMenu : CLIMenu
    {
        private IReservationDAO reservationDAO;
        private List<Campground> CampGrounds;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parkID">Database ID of the park to search for a reservation</param>
        /// <param name="resDaoParam">An object that implements a DAO for Reservations</param>
        /// <param name="campgrParam">An object that implements a DAO for Campgrounds</param>
        public SearchReservationMenu(int parkID, IReservationDAO resDaoParam, ICampgroundDAO campgrParam) 
            : base()
        {
            this.CampGrounds = campgrParam.GetCampgroundsByParkId(parkID);
            this.reservationDAO = resDaoParam;
            
            this.Title = "Search for Campground Reservation";
           
            
            int i = 1;
            foreach (Campground campground in CampGrounds)
            {
                this.menuOptions.Add(i.ToString(), campground.Name.PadRight(25) + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(campground.Open_From_Mm).PadRight(10) +
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(campground.Open_To_Mm).PadRight(10) + $"{campground.Daily_Fee:C}");
                i++;
            }
            this.menuOptions.Add("Q", "Go Back");
            Console.WriteLine();
            
        }
        protected override void DisplayBeforeMenu()
        {
            Console.WriteLine("    " + "Name".PadRight(25) + "Open".PadRight(10) + "Close".PadRight(10) + "Daily Fee");
        }
        protected override void DisplayAfterMenu()
        {
            Console.WriteLine("Which campground (enter Q to cancel)? ");
        }

        protected override bool ExecuteSelection(string choice)
        {
            int choiceInt = -1;
            if (int.TryParse(choice, out choiceInt))
            {
                // Check if selection is within the range of menu options
                if (choiceInt == 0)
                {
                    return false;    //go back to previous menu
                }
                
                // Check if selection is within the range of menu options
                if (choiceInt <= CampGrounds.Count && choiceInt > 0)
                {
                    //get dates from the user

                    DateTime arrival = new DateTime();
                    DateTime departure = new DateTime();
                    Console.WriteLine("What is the arrival date? (MM/DD/YYYY) ");
                    DateTime.TryParse(Console.ReadLine(), out arrival);
                    Console.WriteLine("What is the departure date? (MM/DD/YYYY) ");
                    DateTime.TryParse(Console.ReadLine(), out departure);
                    
                    //check if either date failed to parse
                    if (arrival == new DateTime() || departure == new DateTime())
                    {
                        Console.WriteLine("Please enter dates in a valid format (ex 07/24/2019)");
                        Console.ReadKey();
                        return true;
                    }
                    //if departure is before arrival
                    if (departure <= arrival)
                    {
                        Console.WriteLine("Departure date must be later than arrival date. Press any key to try again.");
                        Console.ReadKey();
                        return true;
                    }
                    //check that dates are within open season
                    if(arrival.Month < this.CampGrounds[choiceInt-1].Open_From_Mm || departure.Month > this.CampGrounds[choiceInt-1].Open_To_Mm)
                    {
                        Console.WriteLine("Please select dates within the open months. Press any key to try again.");
                        Console.ReadKey();
                        return true;
                    }
                    //time travel is not allowed
                    if(arrival < DateTime.Now)
                    {
                        Console.WriteLine("Cannot exceed 87mph. Please try dates in the future. Press any key to try again.");
                        Console.ReadKey();
                        return true;
                    }

                    MakeReservationMenu menu = new MakeReservationMenu(reservationDAO, this.CampGrounds[choiceInt-1], arrival, departure);
                    // This if statement handles the case where a search returned no available sites, so that the user
                    // does not get a weird looking screen asking them to choose a site with no options to choose. 
                    // In other words, the menu only runs from here if reservations were found. 
                    // It returns false so that, after the reservation is made, we will revert to the main menu.

                    if (menu.FoundReservations)
                    {
                        menu.Run();
                        return false;
                    }
                    // Returning true in this instance--where there were no reservations found--takes the user back to the previous
                    // menu, to select a different campground from this park, or to select Q to return to the main menu. 
                    return true;

                }
            }
            Console.WriteLine("Invalid input, press any key to try again.");
            Console.ReadKey();
            return true;
        }
    }
}
