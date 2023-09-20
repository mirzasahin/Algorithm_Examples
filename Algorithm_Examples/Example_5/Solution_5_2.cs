/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates the factorial of the entered number.
    internal class Solution_5_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to calculate the factorial.");
            int number = int.Parse(Console.ReadLine());
            int count = number;
            int sum = 1;

            while (count > 0)
            {
                sum *= count;
                count--;
            }

            Console.WriteLine($"{number} factorial is equals to {sum}");
        }
    }
}
*/