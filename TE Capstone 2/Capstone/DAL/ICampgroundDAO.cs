using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;

namespace Capstone.DAL
{
    public interface ICampgroundDAO
    {
        /// <summary>
        /// Get all Campgrounds in a given park
        /// </summary>
        /// <param name="parkId">The park_id of the park to search</param>
        /// <returns>A List of the campgrounds inside the park</returns>
        List<Campground> GetCampgroundsByParkId(int parkId);
    }
}
