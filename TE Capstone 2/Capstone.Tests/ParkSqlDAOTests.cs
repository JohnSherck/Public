using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Models;
using Capstone.DAL;

namespace Capstone.Tests
{
    [TestClass]
    public class ParkSqlDAOTests : DAOTests
    {
        [TestMethod]
        public void GetAllParks_Test_ShouldReturnParks()
        {
            //Arrange
            ParkSqlDAO dao = new ParkSqlDAO(this.connectionString);
            //Act
            List<Park> list = new List<Park>();
            list = dao.GetAllParks();
            //Assert
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("Acadia", list[0].Name);
            Assert.AreEqual("Arches", list[1].Name);
            Assert.AreEqual("Cuyahoga Valley", list[2].Name);
        }
        //GetAllParks
    }
}
