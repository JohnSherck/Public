using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Models;
using Capstone.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Tests
{
    [TestClass]
    public class CampgroundSqlDAOTests : DAOTests
    {
        
        [TestMethod]
        public void GetCampgroundsByParkId(int parkID, int campgroundCount)
        {
            //Arrange
            CampgroundSqlDAO dao = new CampgroundSqlDAO(this.connectionString);
            List<Campground> list = new List<Campground>();
            List<Campground> list2 = new List<Campground>();
            //int id = this.getMaxIdFromTable("park", "park_id");
            //if (id > 0)
            //{
            //    //Act
            //    list = dao.GetCampgroundsByParkId(id);
            //    list2 = dao.GetCampgroundsByParkId(id - 1);
            //    //Assert
            //    Assert.AreEqual(1, list.Count);
            //    Assert.AreEqual(3, list2.Count);
            //}

        }

    }
}
