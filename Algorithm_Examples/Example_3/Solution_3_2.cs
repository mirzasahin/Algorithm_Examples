using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates the cube of the entered number.
    internal class Solution_3_2
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            int counter = 1;
            while (counter <= 10)
            {
                totalSum += Math.Pow(counter, 3);
                if (counter == 10)
                    break;
                counter++;
            }
            Console.WriteLine(totalSum);
        }
    }
}