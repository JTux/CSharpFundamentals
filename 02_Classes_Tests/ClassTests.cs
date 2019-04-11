using System;
using _02_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Classes_Tests
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie newCookie = new Cookie();
            newCookie.CookieName = "Chocolate Chip";
            newCookie.FlourAmount = 2.5d;
            newCookie.ArmCount = 0;
            newCookie.LegCount = 1;
            newCookie.HasNuts = false;
            newCookie.SugarAmount = 12.2d;
            newCookie.DateBaked = DateTime.Now;

            Assert.AreEqual(1, newCookie.LegCount);

            DateTime today = new DateTime(2019, 4, 10);

            Cookie datedCookie = new Cookie(new DateTime(2019, 4, 11));
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.Color = "Red";
            car.HasEngine = true;
            car.HasWheels = false;
            car.Mileage = 28000;
            car.NumberOfDoors = 4;
            car.NumberOfSeats = 5;
            car.NumberOfWheels = 4;

            Assert.AreEqual(4, car.NumberOfWheels);
            Assert.IsTrue(car.HasEngine);
            Assert.IsFalse(car.HasWheels);
        }

        [TestMethod]
        public void CustomerTests()
        {
            Customer newCustomer = new Customer();

            string name = "Luke";

            newCustomer.Name = name;
            newCustomer.HadAccident = true;
            newCustomer.AccidentCount = 23;
            newCustomer.Age = 17;
            newCustomer.Premium = 10000;

            Customer namedCustomer = new Customer("Josh", false, 0, 24, 1000);
            Customer ransford = new Customer("Ransford", false, 0, 24, 1000);
            Customer kenn = new Customer("Kenn", false, 0, 24, 1000);
            Customer lawrence = new Customer("Lawrence", false, 0, 24, 1000);
        }
    }
}
