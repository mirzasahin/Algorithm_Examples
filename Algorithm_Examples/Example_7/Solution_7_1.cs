
/* namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating an algorithm that uses subtraction to divide positive numbers.
    internal class Solution_7_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to divide.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to divide.");
            int number2 = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = number1;
            int remainder = 0;

            for (int i = 0; i < number1; i++)
            {
                counter -= number2;
                sum++;
                if (counter < number2)
                {
                    remainder = counter;
                    break;
                }
            }

            Console.WriteLine($"{number1} / {number2} = {sum} | remainder: {remainder}");
        }
    }
}
*/