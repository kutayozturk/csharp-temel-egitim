// Ref Anahtar Kelimesi

// ref anahtar kelimesi, çağrılan değişkenin orjinal değerine yansıtmak istediğimiz zaman kullanıyoruz.
// Aslında değer değişmiyor ama geçici olarak, etkileniyor.

// ref anahtar kelimesi metot içerisinde varsa, metot çağrılırkende de kullanılmalıdır.
// ref ile oluşturduysan, ref ile çağıracaksın.

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double sayi = 10.0;
            Console.WriteLine("sayı: "+ sayi);
            Yuzde18Hesapla(ref sayi);
            Console.WriteLine("Yeni sayı değeri: " + sayi);

            Console.ReadLine();
           
        }
        static void Yuzde18Hesapla(ref double sayi)
        {
            sayi = sayi * 0.18;
        }
    }
    

}
