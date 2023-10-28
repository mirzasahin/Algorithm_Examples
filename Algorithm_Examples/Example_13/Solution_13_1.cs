using System.CodeDom.Compiler;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating Fizz Buzz algorithm.
    internal class Solution_13_1
    {
        static void Main(string[] args)
        {
            fizzBuzz(5);
        }

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

