using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm where the computer guesses a number and the user tries to find that number.
    internal class Solution_10_1
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int memory;
            int count = 0;

            Random number = new Random();
            memory = number.Next(1, 100);

            while (guess != memory)
            {
                count++;
                Console.WriteLine("Guess the number!");
                guess = Convert.ToInt16(Console.ReadLine());

                if (guess > memory)
                {
                    Console.WriteLine("Below!");
                }
                else if (memory > guess)
                {
                    Console.WriteLine("Above!");
                }
            }

            Console.WriteLine("Congrats! You guessed the number correctly.");
        }
    }
}
