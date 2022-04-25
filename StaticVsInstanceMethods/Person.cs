using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVsInstanceMethods
{
    internal class Person
    {
        public static string species = "Homo Sapiens";
        public static string homeWorld = "Earth";
        public string Name { get; set; }
        public string HairColor { get; set; }
        public int SSN { get; set; }

        public Person(string name, string hairColor, int ssn)
        {
            Name = name;
            HairColor = hairColor;
            SSN = ssn;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static void PrintSpecies()
        {
            Console.WriteLine(species);
        }
    }
}
