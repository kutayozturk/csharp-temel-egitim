// Out Anahtar Kelimesi

// out anahtar kelimesi, değeri tanımlanmayan bir değişkene, varsayılan bir değer ile kullanmaya yarar.
// Metot'un içerisinde tanımlamış olduğumuz değeri, ilgili değişkene atamışız gibi kullanmamıza yarar.
// Out kullandıldığı zaman metot içerisinde değişkene değer ataması zorunludur.

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double sayi;
            Console.WriteLine("sayı: ");
            Yuzde18Hesapla(out sayi);
            Console.WriteLine("Yeni sayı değeri: " + sayi);

            Console.ReadLine();
        }

        private static void Yuzde18Hesapla(out double sayi)
        {
            sayi = 10;
            sayi = sayi * 0.18;
        }
    }
}
