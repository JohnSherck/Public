using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Capstone.Tests
{
    [TestClass]
    public abstract class DAOTests
    {
        protected int AcadiaID = 0;
        protected int BlackwoodsID = 0;
        protected int campsite1ID = 0;

        protected string connectionString = "Server=.\\SqlExpress; Database=npcampground; Trusted_Connection=true;";
        private TransactionScope transaction;

        [TestInitialize]
        public void Setup()
        {
            transaction = new TransactionScope();
            string script = File.ReadAllText(@"..\..\..\campground-testing.sql");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Open the Connection
                conn.Open();
                SqlCommand cmd = new SqlCommand(script, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    this.AcadiaID = Convert.ToInt32(reader["AcadiaID"]);
                    this.BlackwoodsID = Convert.ToInt32(reader["BlackwoodsID"]);
                    this.campsite1ID = Convert.ToInt32(reader["campsite1ID"]);                    
                }                
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Roll back the transaction
            this.transaction.Dispose();
        }
    }
}
