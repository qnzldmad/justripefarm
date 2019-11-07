using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paractical07_re_;
using MySql.Data.MySqlClient;

namespace JustRipeFarmUnitTest
{
    [TestClass]
    public class UnitTestLabourerHandler
    {
        [TestMethod]
        public void TestAddNewLabourer()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Labourer labrA = new Labourer();
            labrA.Name = "Bob";
            labrA.Age = 39;
            labrA.Gender = "male";

            LabourerHandler labrHand = new LabourerHandler();
            int resp2 = labrHand.addNewLabourer(dbC.getConn(), labrA);
            Assert.AreEqual(1, resp2);
            //Assert.IsNotNull(resp2);

        
        }
    }
}
