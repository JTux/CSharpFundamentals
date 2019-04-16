using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Console
{
    public class Animal
    {
        public int LegCount { get; set; }
        public bool HasFur { get; set; }
        public bool IsMammal { get; set; }

        public virtual void Run()
        {
            Console.WriteLine("The animal speeds up.");
        }
    }

    public class Cat : Animal
    {
        public double TailLength { get; set; }

        public override void Run()
        {
            Console.WriteLine("The cat runs");
        }
    }

    public class Dog : Animal
    {
        public override void Run()
        {
            //base.Run();
            Console.WriteLine("The dog sprints.");
        }
    }

    public class Bird : Animal
    {

    }

    public class Turtle : Animal
    {

    }

    public class TabbyCat : Cat
    {

    }

}
