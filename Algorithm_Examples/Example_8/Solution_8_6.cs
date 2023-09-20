/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating an algorithm that shows the number of digits of the entered number.
    internal class Solution_8_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to know how many digits it has.");
            Int128 number = Int128.Parse(Console.ReadLine());
            Int128 _number = number;
            
            Int128 sum = number.ToString().Length;
            

            Console.WriteLine($"The number {_number} has {sum} digits.");
        }
    }
}
*/