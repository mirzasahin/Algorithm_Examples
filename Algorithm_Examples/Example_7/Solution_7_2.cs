/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating an algorithm that uses subtraction to divide positive numbers.
    internal class Solution_7_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to divide.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to divide.");
            int number2 = int.Parse(Console.ReadLine());

            int _number1 = number1;
            int sum = 0, remainder;
            

            while (true)
            {
                number1 -= number2;
                sum++;
                if (number1 < number2)
                {
                    remainder = number1;
                    break;
                }
            }

            Console.WriteLine($"{_number1} / {number2} = {sum} | Remainder: {remainder}");
        }
    }
}
*/