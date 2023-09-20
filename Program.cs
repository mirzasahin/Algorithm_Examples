/*namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // Çarpma işlemini toplama işlemi kullanarak recursive fonksiyon ile çözümleyen algoritmayı yaz.
        static void Main(string[] args)
        {
            Console.WriteLine("İlk sayıyı gir.");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı gir.");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = Topla(sayi1, sayi2);
            Console.WriteLine($"{sayi1} * {sayi2} = {sonuc}");
        }

        static int Topla(int sayi1, int sayi2)
        {
            if (sayi2 > 1)
            {
                return sayi1 + Topla(sayi1, --sayi2);
            }
            return sayi1;
        }
    }
}
*/