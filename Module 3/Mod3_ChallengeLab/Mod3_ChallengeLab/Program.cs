using System;

namespace Mod3_ChallengeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Getting student's birthday...");
            DateTime birthday = DateTime.Now;
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on {3}", first, last, birthday);
        }
    }
}
