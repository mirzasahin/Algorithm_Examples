/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates multiplication by addition.
    internal class Solution_6_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int number2 = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = number2;

            while (count > 0)
            {
                sum += number1;
                count--;
            }
            Console.WriteLine($"{number1} * {number2} = {sum}");
        }
    }
}
*/
