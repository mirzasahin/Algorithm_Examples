/*namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the algorithm that calculates the factorial of the entered number.
    internal class Solution_5_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to calculate the factorial.");
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            
            do
            {
                sum *= number;
                number--;
                if (number == 0) break;
            } while (true);

            Console.WriteLine(sum);
        }   
    }
}
*/