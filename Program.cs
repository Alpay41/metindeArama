namespace metindeArama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Metin Giriniz");

            string metin = Console.ReadLine();

            Console.WriteLine("Lütfen Aranacak Harfi Giriniz");

            char harf = char.Parse(Console.ReadLine());
            int adet = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == harf)
                {
                    adet++;
                }

            }
            Console.WriteLine("{0}  Metninde Aradığınız  {1} Harfi Sayısı {2}  adet", metin, harf, adet);
        }
    }
}