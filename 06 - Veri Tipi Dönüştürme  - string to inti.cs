using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayiyi Gir: ");

            // Kosnol ekranında veri alma tipi aslında string'dir. int olarak tanımlama yaptığımızda hata verecektir.
            // Hata tipi, bir syntax hatası değildir. Girilen ifadeleri yanyana yazacaktır, değerleri toplamayacaktır.
            // Bu sorunu gidermek için string veri tipini int veri tipine dönüştürmemiz gerekmektedir.

            int sayi1 = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 komutu, string veri tipini int veri tipine dönüştürür.
            // int16 sayi1 = Convert.ToInt16(Console.ReadLine());   int16 tipine dönüştürme işlemdir. En başta'da int16 olarak belirtmemiz gerekmektedir.
            // int16 ve int32 arasındaki fark ise, değer aralığıdır.
            Console.WriteLine("2.Sayiyi Gir: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam: " + (sayi1 + sayi2));

            Console.ReadLine();


        }
    }
}
