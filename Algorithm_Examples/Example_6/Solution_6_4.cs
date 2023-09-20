/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates multiplication by addition.
    internal class Solution_6_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiplication(number1, number2));
        }

        static int Multiplication(int number1, int number2)
        {
            if(number2 > 1)
            {
                return number1 + Multiplication(number1, --number2);
            }
            return number1;
        }
    }
}
*/
