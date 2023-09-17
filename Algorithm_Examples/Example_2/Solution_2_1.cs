using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that gives the sum of the squares of the entered numbers.
    internal class Solution_2_1
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Enter first number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int number2 = int.Parse(Console.ReadLine());

            int sum = (number1 * number1) + (number2 * number2);
            Console.WriteLine("The sum of the squares of the numbers you entered: " + sum);
            }

            catch
            {
                Console.WriteLine("Please enter a value of number type only.");
            }
        }
    }
}