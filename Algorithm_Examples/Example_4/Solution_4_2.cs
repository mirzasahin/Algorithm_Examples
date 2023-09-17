using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating the age calculation algorithm.
    internal class Solution_4_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your date of birth in the format Day, Month, Year with dots between them.");

            try
            {
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
                DateTime today = DateTime.Now;

                int age = today.Year - dateOfBirth.Year;

                if (dateOfBirth > today.AddYears(-age))
                    age--;

                Console.WriteLine(age);
            }
            catch
            {
                Console.WriteLine("Please enter a valid login.");
            }
        }
    }
}