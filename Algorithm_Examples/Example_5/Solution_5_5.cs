/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates the factorial of the entered number.
    internal class Solution_5_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to calculate the factorial.");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(number));
        }

        static int Factorial(int number)
        {
            if (number > 1)
            {
                return number * Factorial(--number);
            }
            else
            {
                return number;
            }
        }
    }
}
*/