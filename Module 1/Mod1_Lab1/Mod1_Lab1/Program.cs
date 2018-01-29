using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create some variables with default values
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            //Assign some values
            firstName = "Thomas";
            lastName = "Aschemann";
            age = 27;
            street = "123 Fake Street";
            city = "Carbondale";
            country = "USA";
            birthDate = new DateTime(1970, 1, 1);

            //Output
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //Use placeholder style
            Console.WriteLine("{0} years old.",age);

            //use string concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            //Use string interpolation
            Console.WriteLine($"Born on {birthDate}");

            //Console.WriteLine("Hello World!");
        }
    }
}
