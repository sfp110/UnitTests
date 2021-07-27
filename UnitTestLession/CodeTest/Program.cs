﻿using System;

namespace CodeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menuNumber=0;

            do
            {
                Console.WriteLine("What time is it?");
                string input = Console.ReadLine();
                int number;

                if (Int32.TryParse(input, out number))
                {
                    Console.WriteLine(Greeting(number));
                    menuNumber+=1;

                }
                else
                    Console.WriteLine("Your date does not work. \n");
            }
            while (menuNumber == 0);
            
        }

        public static string Greeting(int number)
        {
            string greeting;
            if (number >= 5 && number <= 12)
            {
                greeting = "Good Morning";
            }
            else if (number >= 12 && number <= 18)
            {
                greeting = "Good Afternoon";
            }
            else
                greeting = "Good Evening";

            return greeting;
        }
    }
}
