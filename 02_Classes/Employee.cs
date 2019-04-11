using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Classes
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsOfService { get; set; }

        public Employee() { }
        public Employee(int id, string lastName, int age, int yearsOfService)
        {
            ID = id;
            LastName = lastName;
            Age = age;
            YearsOfService = yearsOfService;
        }
    }
}
