/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates multiplication by addition.
    internal class Solution_6_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int number2 = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = 0; i < number1; i++)
            {
                sum += number2;
            }

            Console.WriteLine($"{number1} * {number2} = {sum}");
        }
    }
}
*/