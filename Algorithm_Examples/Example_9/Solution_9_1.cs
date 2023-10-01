/* namespace MyApp // Note: actual namespace depends on the project name.
{
    // Creating an algorithm that finds whether the sum of the
    // cubes of the digits of an entered 3-digit number is equal to itself.
    internal class Solution_9_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 basamaklı bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int _sayi = sayi;
            int sonuc = 0;

            if (Basamak(sayi))
            {
                while (true)
                {
                    int basamak = sayi % 10;
                    sonuc += basamak * basamak * basamak; // Math.Pow(basamak, 3);
                    sayi /= 10;

                    if (sayi < 1)
                    {
                        break;
                    }
                }

                if (sonuc == _sayi)
                {
                    Console.WriteLine("Eşittir.");
                }
                else
                {
                    Console.WriteLine("Eşit değildir.");
                }
            }
            else
            {
                Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz.");
            }
        }

        static bool Basamak(int sayi)
        {
            int basamakSayisi = 1;
            while (true)
            {
                basamakSayisi++;
                sayi /= 10;

                if (sayi < 10)
                {
                    break;
                }
            }
            return basamakSayisi == 3 ? true : false;
        }
    }
}
*/
