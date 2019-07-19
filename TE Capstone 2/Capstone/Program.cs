using Capstone.Views;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Capstone.DAL;
using Capstone.Models;
namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the connection string from the appsettings.json file
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("Project");
            IParkDAO parkDao = new ParkSqlDAO(connectionString);
            ICampgroundDAO campDao = new CampgroundSqlDAO(connectionString);
            IReservationDAO resDao = new ReservationSqlDAO(connectionString);
            

            // Create a menu and run it
            ViewParksMenu menu = new ViewParksMenu(campDao, parkDao, resDao);
            menu.Run();
        }
    }
}
