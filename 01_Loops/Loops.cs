using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 11;

            //1 Starting Point
            //2 While this condition is true, keep looping
            //3 What we do after each loop
            //for  //1      //2        //3
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string name = "Joshua";

            //1 Collection being worked on
            //2 Name of the current type being used
            //3 Current type in collection
            //4 in keyword used to seperate the individual and the collection
            //foreach //3 //2   //4 //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

            List<string> students = new List<string>();
            students.Add("Cody");
            students.Add("Amanda");
            students.Add("Scott");
            students.Add("Banana");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //1 Loop runs while this statement is true
            //while //1
            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }
        }
    }
}
