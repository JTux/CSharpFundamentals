using System;
using _02_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Classes_Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void EmployeePropertyTest()
        {
            Employee employee = new Employee(1, "Tucker", 24, 1);
            Assert.AreEqual(1, employee.ID);
            Assert.AreEqual("Tucker", employee.LastName);
            Assert.AreEqual(24, employee.Age);
            Assert.AreEqual(1, employee.YearsOfService);
        }

        [TestMethod]
        public void EmployeeSignupAgeTest()
        {
            // Arrange
            Employee employee = new Employee(1, "Tucker", 24, 1);

            // Act
            int actual = employee.CalculateSignupAge();
            int expected = 23;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
