using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Types()
        {
            int age;
            age = 24;
            int age2 = 24;
            Int16 int16 = 16;
            short shortMin = -32768;
            short shortMax = 32767;
            Int32 int32 = 32;
            Int64 int64 = 64;
            long longMin = -9223372036854775808;
            float floatExample = 1.234567f;
            byte byteMin = 0;
            byte byteMax = 255;
            double doubleExample = 1.7890d;
            decimal decimalExample = 1.7000m;

            string stringExample = "This is a string";
            string thisIsAnExampleNumberString = "7";
            string name;
            name = "Josh";
            stringExample = "This is the new value";

            string newString = stringExample + " " + name;
            string interpolate = $"{name}. Here is the string: {stringExample}";

            Console.WriteLine(interpolate);

            int a = 15;
            int b = -10;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.Write((a / b) + " r");
            Console.WriteLine(a % b);

            DateTime today = DateTime.Now;
            DateTime graduation = new DateTime(2019, 6, 29);

            TimeSpan ageSpan = today - graduation;
            Console.WriteLine(ageSpan.TotalSeconds);
            Console.WriteLine(today);

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Josh");

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('a', "Ransford");

            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

            string anotherExample = "Hello World!";
            string[] stringArray = { anotherExample, "Hello", "World", "!" };
            string[] students = new string[11];

            Console.WriteLine(students);
        }

        [TestMethod]
        public void Conditionals()
        {
            int age = 24;
            age = 17;

            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're far too young to be on a computer");
            }
            else
            {
                Console.WriteLine("You're not born yet");
            }

            if (age < 65 && age > 18)
            {
                // And comparison
            }
            if (age > 65 || age < 18)
            {
                // Or comparison
            }
            if (age == 21)
            {
                // Is equal to
            }
            if (age != 19)
            {
                // Not equals to
                // Bang operator
            }

            switch (age)
            {
                case 18:
                    // 18 year old code
                    break;
                case 19:
                    // 19 year old code
                    break;
                case 20:
                    // 20 year old code
                    break;
                case 21:
                    // 21 year old code
                    break;
                case 22:
                    Console.WriteLine("Hi");
                    break;
                case 23:
                case 24:
                default:
                    Console.WriteLine("You are not 18-24");
                    break;
            }
        }

        [TestMethod]
        public void Methods()
        {
            int banana = AddTwoNumbers(7, 5);
            Assert.AreEqual(12, banana);
            int subtractedBanana = SubtractTwoNumbers(12, 8);
            Assert.AreEqual(4, subtractedBanana);
            int product = MultiplyTwoNumbers(2, 10);
            Assert.IsTrue(product == 20);
            int fruitSalad = DivideTwoNumbers(10, 3);
            Assert.AreEqual(3, fruitSalad);

            Assert.AreEqual(1, FindRemainderFromTwoNumbers(10,3));
        }
        //Access modifier    return type   Method Signature
        private int AddTwoNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }
        private int MultiplyTwoNumbers(int numOne, int numTwo)
        {
            int banana = numOne * numTwo;
            return banana;
        }
        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }
        private int FindRemainderFromTwoNumbers(int a, int b)
        {
            int remainder = a % b;
            return remainder;
        }
    }
}
