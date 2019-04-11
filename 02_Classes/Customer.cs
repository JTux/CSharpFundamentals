using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Classes
{
    public class Customer
    {
        public string Name { get; set; }
        public bool HadAccident { get; set; }
        public int AccidentCount { get; set; }
        public int Age { get; set; }
        public decimal Premium { get; set; }

        public Customer()
        {

        }

        public Customer(string name, bool hadAccident, int accidentCount, int age, decimal premium)
        {
            Name = name;
            HadAccident = hadAccident;
            AccidentCount = accidentCount;
            Age = age;
            Premium = premium;
        }
    }
}
