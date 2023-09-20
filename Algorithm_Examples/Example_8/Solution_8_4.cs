/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating an algorithm that shows the number of digits of the entered number.
    internal class Solution_8_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to know how many digits it has.");
            float number = float.Parse(Console.ReadLine());
            int count = 0;
            float _number = number;

            do
            {
                number /= 10;
                count++;
            } while (number >= 1);


            Console.WriteLine($"The number {_number} has {count} digits.");
        }
    }
}
*/