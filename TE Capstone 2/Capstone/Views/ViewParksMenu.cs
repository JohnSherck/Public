using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using Capstone.DAL;

namespace Capstone.Views
{
    public class ViewParksMenu : CLIMenu
    {

        private ICampgroundDAO campgroundDAO;
        private IParkDAO parkDAO;
        private IReservationDAO reservationDAO;
        private List<Park> parkList;

        public ViewParksMenu(ICampgroundDAO campground, IParkDAO park, IReservationDAO reservation) : base()
        {
            this.campgroundDAO = campground;
            this.parkDAO = park;
            this.reservationDAO = reservation;
            this.parkList = park.GetAllParks();


            this.Title = "Select a park for further details";
            int i = 1;
            foreach (Park currentPark in parkList)
            {
                this.menuOptions.Add(i.ToString(), currentPark.Name);
                i++;
            }
            this.menuOptions.Add("Q", "Quit");
        }



        protected override bool ExecuteSelection(string choice)
        {
            int choiceInt = 0;
            if (int.TryParse(choice, out choiceInt))
            {
                // Check if selection is within the range of menu options
                if (choiceInt <= parkList.Count && choiceInt > 0)
                {
                    ParkInformationMenu menu = new ParkInformationMenu(this.campgroundDAO, this.reservationDAO, this.parkList[choiceInt-1]);
                    menu.Run();
                    return true;
                } 
            }
                Console.WriteLine("Invalid input, press any key to try again.");
                Console.ReadKey();
                return true;
        }
    }
}
