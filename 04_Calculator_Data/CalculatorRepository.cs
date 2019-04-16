using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calculator_Data
{
    public class CalculatorRepository
    {
        /// <summary>
        /// Calculates and returns the sum of the two double parameters.
        /// </summary>
        /// <param name="numOne">First number.</param>
        /// <param name="numTwo">Second number, added to the first.</param>
        /// <returns>Sum of numOne and numTwo.</returns>
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        /// <summary>
        /// Calculates and returns the sum all values in the given List.
        /// </summary>
        /// <param name="numbers">List of all numbers to be added together.</param>
        /// <returns></returns>
        public double Add(List<double> numbers)
        {
            double sum = 0;

            foreach(double number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        /// <summary>
        /// Calculates and returns the difference between the two double parameters.
        /// </summary>
        /// <param name="numOne">First number.</param>
        /// <param name="numTwo">Second number, subtracted to the first.</param>
        /// <returns>Difference between numOne and numTwo.</returns>
        public double Subtract(double numOne, double numTwo)
        {
            double diff = numOne - numTwo;
            return diff;
        }

        public double Subtract(List<double> numbers, double startingNumber)
        {
            double total = startingNumber;
            foreach(double number in numbers)
            {
                total = total - number;
            }
            return total;
        }

        /// <summary>
        /// Calculates and returns the product of the two double parameters.
        /// </summary>
        /// <param name="numOne">First number, to be multiplied by the second.</param>
        /// <param name="numTwo">Second number, to be multiplied by the first.</param>
        /// <returns>Product of numOne and numTwo.</returns>
        public double Multiply(double numOne, double numTwo)
        {
            double prod = numOne * numTwo;
            return prod;
        }

        /// <summary>
        /// Calculates and returns the quotient from dividing the dividend by the divisor.
        /// </summary>
        /// <param name="dividend">First number, the dividend.</param>
        /// <param name="divisor">Second number, the divisor.</param>
        /// <returns>Quotient from dividing the dividend by the divisor.</returns>
        public double Divide(double dividend, double divisor)
        {
            double quotient = dividend / divisor;
            return quotient;
        }
    }
}
