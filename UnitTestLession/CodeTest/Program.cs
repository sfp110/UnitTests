using System;

namespace CodeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GreetingExercise();

            RatingExercise();
        }
        public static void GreetingExercise()
        {
            int menuNumber = 0;
            do
            {
                Console.WriteLine("What time is it?");
                string input = Console.ReadLine();
                int number;

                if (Int32.TryParse(input, out number) && number <= 24)
                {
                    Console.WriteLine(Greeting(number));
                    menuNumber += 1;

                }
                else
                    Console.WriteLine("Your date does not work. \n");
            }
            while (menuNumber == 0);
        }

        public static string Greeting(int number)
        {
            string greeting;

            if (number >= 5 && number < 12)
                greeting = "Good Morning";

            else if (number >= 12 && number <= 18)
                greeting = "Good Afternoon";

            else if (number > 18 && number <= 24)
                greeting = "Good Evening";

            else if (number < 5)
                greeting = "Go to bed!";

            else
            {
                greeting = "Error.";
            }
               

            return greeting;
        }

        public static void RatingExercise()
        {
            int menuNumber = 0;
            do
            {
                Console.Write("Please Inser your age: ");
                string input = Console.ReadLine();

                //Type esc to exit application
                if (input == "esc" )
                {
                    Environment.Exit(0);
                }
                else
                {
                    int number;

                    if (Int32.TryParse(input, out number))
                    {
                        Console.WriteLine(AvailableClassifications(number) + "\n");
                        //menuNumber += 1;
                        //Type esc to exit application

                    }
                    else
                        Console.WriteLine("Error. \n");
                }
                
            }
            while (menuNumber == 0);
        }

        public static string AvailableClassifications(int ageOfViewer)
        {
            string result = "";
            if (ageOfViewer <12)
            {
                result = "U & PG films are available.";
            }

            if (ageOfViewer >= 12 && ageOfViewer < 15)
            {
                result = "U, PG & 12 films are available.";
            }

            else if (ageOfViewer >= 15 && ageOfViewer < 18)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else if (ageOfViewer >= 18)
            {
                result = "All films are available.";
            }

            return result;
        }
    }
}
        
