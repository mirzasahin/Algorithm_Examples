using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm where the computer guesses a number and the user tries to find that number.
    internal class Solution_11_1
    {
        static List<int> numbers = new List<int>() {1, 2, 3, 4};

        static void Main(string[] args)
        {
            Console.WriteLine(simpleArraySum(numbers));
        }

        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
