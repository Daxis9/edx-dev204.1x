﻿using System;

namespace Mod2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //For  Loop
            for(int counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine($"Counter is at: {counter}");
            }

            //Nested Loop
            int outer;
            int inner;

            for(outer = 2; outer < 100; outer++)
            {
                for(inner = 2; inner <= (outer/inner); inner++)
                {
                    if ((outer % inner) == 0) break; //if factor not found, not prime
                }
                if(inner > (outer / inner))
                {
                    Console.WriteLine("{0} is prime.", outer);
                }
            }
        }
    }
}
