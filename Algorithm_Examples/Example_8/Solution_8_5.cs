/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating an algorithm that shows the number of digits of the entered number.
    internal class Solution_8_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to know how many digits it has.");
            float number = float.Parse(Console.ReadLine());
            float _number = number;

            float sum = DigitNumber(number);
            Console.WriteLine($"The number {_number} has {sum} digits.");
        }

        static int DigitNumber(float number)
        {
            number /= 10;
            if (number >= 1)
            {
                return 1 + DigitNumber(number);
            }
            else
            {
                return 1;
            }
        }
    }
}
*/