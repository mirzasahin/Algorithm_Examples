/*using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the age calculation algorithm.
    internal class Solution_4_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your date of birth in the format Day, Month, Year with dots between them.");

            try
            {
                DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                TimeSpan sum = DateTime.Now - dateOfBirth;
                Console.WriteLine(sum.Days / 365);
            }

            catch
            {
                Console.WriteLine("Please enter a valid login.");
            }
        }
    }
}
*/