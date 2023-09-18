/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating an algorithm that uses subtraction to divide positive numbers.
    internal class Solution_7_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to divide.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to divide.");
            int number2 = int.Parse(Console.ReadLine());
            int counter = number1;

            int division = 0;
            for (int i = 0; counter >= number2; i++)
            {
                counter -= number2;
                division += 1;
            }
            Console.WriteLine($"{number1} / {number2} = {division}");

        }
    }
}
*/
