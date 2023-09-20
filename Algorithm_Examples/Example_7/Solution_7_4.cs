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

            Console.WriteLine(Divide(number1, number2));
        }

        static int Divide(int number1, int number2)
        {
            number1 -= number2;
            if (number1 >= number2)
            {
                return 1 + Divide(number1, number2);
            }
            else
            {
                return 1;
            }
        }
    }
}
*/
