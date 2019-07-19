using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;

namespace Capstone.DAL
{
    public interface IParkDAO
    {
        /// <summary>
        /// Returns a List containing all Parks
        /// </summary>
        /// <returns>A List of all parks</returns>
        List<Park> GetAllParks();



    }
}
