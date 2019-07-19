using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Models;
using Capstone.DAL;

namespace Capstone.Tests
{
    [TestClass]
    public class ReservationSqlDAOTests : DAOTests
    {
        public DateTime start = new DateTime(2019, 7, 4);
        public DateTime end = new DateTime(2019, 7, 6);

        [TestMethod]
        public void CreateReservation()
        {
            //Arrange
            ReservationSqlDAO dao = new ReservationSqlDAO(this.connectionString);
            List<Reservation> reservations = new List<Reservation>();
            //int id = this.getMaxIdFromTable("site", "site_id");
            //if (id > 0)
            //{
            //    reservations = dao.GetReservationsBySiteId(1);
            //    int countBeforeAdd = reservations.Count;
            //    //Act
            //    int resId = dao.CreateReservation(1, "Peter Parker", start, end, DateTime.Now);

            //    reservations = dao.GetReservationsBySiteId(1);
            //    int countAfterAdd = reservations.Count;
            //    //Assert
            //    Assert.AreEqual(countBeforeAdd + 1, countAfterAdd);
            //}
        }

        [TestMethod]
        public void GetAvailableSites_Test_Should_Return_List()
        {
            //Arrange
            ReservationSqlDAO dao = new ReservationSqlDAO(this.connectionString);
            
            //Act
            List<Site> list = dao.GetAvailableSites(start, end, this.BlackwoodsID);
            
            //Assert
            Assert.AreEqual(5, list.Count);
        }
    }
}
