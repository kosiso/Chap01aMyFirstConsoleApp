using System;
using static System.Console;

namespace Chap01aMyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatorExamples();
            TryAnIf();
            TrySomeLoop();
            TryAnIfElse();
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                WriteLine("x must be 10");
            }
            else
            {
                WriteLine("x isn't 10");
            }
        }

        private static void TrySomeLoop()
        {
            int count = 0;
            while (count < 10)
            {
                count += 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }
            WriteLine($"The answer is {count}");
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";

            if ((someValue == 3) && (name == "Joe"))
            {
                WriteLine("x is 3 and the name is Joe");
            }
            WriteLine("This line runs no matter what");
        }

        private static void OperatorExamples()
        {
            // This statement declares a variable and set it to 3
            int width = 3;

            // The ++ operator increments a variable (adds 1 to it)
            width++;

            /* 
             * Declare two more variable to hold numbers and use the + and *
             * operators to add and multiply values
             */
            int height = 2 + 4;
            int area = width * height;
                        
            Console.WriteLine($"The area is {area}.");

            while (area < 20)
            {
                height++;
                area = width * height;
            }

            do
            {
                width--;
                area = width * height;
            } while (area > 25);

            // A boolean variable is either true or false
            bool trueValue = true;
            Console.WriteLine(trueValue);
        }
    }
}
