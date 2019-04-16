using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Cat whiskers = new Cat();

            animal.LegCount = 2;
            whiskers.TailLength = 4.2;

            Dog fluffy = new Dog();

            List<Animal> animals = new List<Animal>();
            animals.Add(animal);
            animals.Add(whiskers);
            animals.Add(fluffy);

            List<Cat> cats = new List<Cat>();
            cats.Add(whiskers);

            foreach (Animal creature in animals)
            {
                creature.Run();
            }

            Console.ReadLine();
        }
    }
}
