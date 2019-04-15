using System;
using System.Collections.Generic;
using _04_Calculator_Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Calculator_Tests
{
    [TestClass]
    public class CalculatorRepositoryTests
    {
        [TestMethod]
        public void CalcRepo_AddTwoNumbers_ShouldReturnCorrectDouble()
        {
            // Arrange
            CalculatorRepository repo = new CalculatorRepository();

            // Act
            double expected = repo.Add(7, 5);
            double actual = 12;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcRepo_AddListOfNumbers_ShouldReturnCorrectDouble()
        {
            // Arrange
            CalculatorRepository repo = new CalculatorRepository();
            List<double> numberList = new List<double>();
            numberList.Add(7d);
            numberList.Add(2d);
            numberList.Add(3d);
            numberList.Add(4d);
            numberList.Add(3.25d);
            numberList.Add(1d);

            // Act
            double expected = 20.25;
            double actual = repo.Add(numberList);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcRepo_SubtractTwoNumbers_ShouldReturnCorrectDouble()
        {
            // Arrange
            CalculatorRepository repo = new CalculatorRepository();

            // Act
            double expected = repo.Subtract(7, 5);
            double actual = 2;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcRepo_MultiplyTwoNumbers_ShouldReturnCorrectDouble()
        {
            // Arrange
            CalculatorRepository repo = new CalculatorRepository();

            // Act
            double expected = repo.Multiply(7, 5);
            double actual = 35;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcRepo_DivideTwoNumbers_ShouldReturnCorrectDouble()
        {
            // Arrange
            CalculatorRepository repo = new CalculatorRepository();

            // Act
            double expected = repo.Divide(12.5, 5);
            double actual = 2.5;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
