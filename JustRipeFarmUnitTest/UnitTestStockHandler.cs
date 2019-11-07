using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paractical07_re_;
using MySql.Data.MySqlClient;

namespace JustRipeFarmUnitTest
{
    [TestClass]
    public class UnitTestStockHandler
    {
        [TestMethod]
        public void TestAddNewStock()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Stock stock = new Stock();

            Stock aStock = new Stock();
            aStock.Type = 1;
            aStock.Quantity = 100;
            aStock.SupplierId = 3;
            aStock.PurchaseDate = new DateTime(2018, 10, 25, 0, 0, 0);
            aStock.ExpiryDate = new DateTime(2019, 1, 24, 0, 0, 0);

            StockHandler labrHand = new StockHandler();
            int resp2 = labrHand.addNewStock(dbC.getConn(), aStock);
            Assert.IsNotNull(resp2);
        }
    }
}
