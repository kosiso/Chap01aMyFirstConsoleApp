using System;

namespace Chap01aMyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
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
