/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates multiplication by addition.
    internal class Solution_6_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int number2 = int.Parse(Console.ReadLine());
            string _sum = "";

            int sum = number1 * number2;

            for(int i = number2; i >= 0; i--)
            {
                if(i > 0)
                {
                    if(i == 1)
                    {
                        _sum += $"{number1}";
                    }
                    else
                    {
                        _sum += $"{number1} + ";
                    }
                }
                else
                {
                    _sum += $" = {sum}";
                }
            }

            Console.WriteLine(_sum);
        }
    }
}
*/