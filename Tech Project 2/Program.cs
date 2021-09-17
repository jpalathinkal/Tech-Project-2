// Author: Joshua Palathinkal
// Date: 9/16/21
// Description: Using C# conditional statements to output a letter grade after the user inputs an integer grade
using System;

namespace Tech_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                string input = Console.ReadLine();

                int grades = int.Parse(input);

                if (grades < 60)
                {
                    Console.WriteLine("Your final letter grade would be an F.");
                }
                else if ((grades > 59) && (grades < 70))
                {
                    Console.WriteLine("Your final letter grade would be a D.");
                }
                else if ((grades > 69) && (grades < 80))
                {
                    Console.WriteLine("Your final letter grade would be a C.");
                }
                else if ((grades > 79) && (grades < 90))
                {
                    Console.WriteLine("Your final letter grade would be a B.");
                }
                else if ((grades > 89) && (grades < 101))
                {
                    Console.WriteLine("Your final letter grade would be an A.");
                }
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter an integer grade value between 0 and 100.");
                Console.ReadKey(true);
            }
        }
    }
}
