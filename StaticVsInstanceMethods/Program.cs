using System;

namespace StaticVsInstanceMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person sean = new Person("Sean", "Red", 12345);
            //Console.WriteLine(sean.ToString());
            Person.PrintSpecies();
        }

        static void PrintString(string str)
        {
            //Console console = new Console(); is not valid syntax
            Console.WriteLine(str);
        }
    }
}
