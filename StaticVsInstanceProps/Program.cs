using System;

namespace StaticVsInstanceProps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reference the static property 'species' of the Person class
            Console.WriteLine(Person.species);
            Console.WriteLine(Person.homeWorld);

            Console.WriteLine("----------");

            // Making instances of the Person class
            Person sean = new Person("Sean", "Red", 12345);
            Console.WriteLine(sean.Name);
            Console.WriteLine(sean.HairColor);
            Console.WriteLine(sean.SSN);

            Console.WriteLine("----------");
            
            Person pearce = new Person("Pearce", "Brown", 23456);
            Console.WriteLine(pearce.Name);
            Console.WriteLine(pearce.HairColor);
            Console.WriteLine(pearce.SSN);
        }
    }
}
