using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is: {result}");   
        }

        static int Sum(int first, int second)
        {
            int sum = first + second;
            //Console.WriteLine($"The sum of {first} and {second} is: {sum}");
            return sum;
        }

        static int Sum(int first,  int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
