using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleRentalapp;


namespace RentalSystemUnitTest
{
    [TestClass]
    public class AddKilometers
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vehicle test = new Vehicle("Toyota", "T54E3", 2008, "TX12WN", 31000, 5.5, "2/12/2018");
            test.AddJourney(379);
            test.AddJourney(678);

            double actual = test.Journey.GetKilometers();
            double expected = 1057;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddKilometersFail()
        {
            Vehicle test = new Vehicle("Toyota", "T54E3", 2008, "TX12WN", 31000, 5.5, "2/12/2018");
            test.AddJourney(397);
            double actual = test.Journey.GetKilometers();
            double expected = 450;
            Assert.AreEqual(expected, actual);
        }

    }
}
