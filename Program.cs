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
            Console.WriteLine(area);

            // The next two statement declares string variable and use + to concatenate them (join them together)
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            // A boolean variable is either true or false
            bool trueValue = true;
            Console.WriteLine(trueValue);
        }
    }
}
