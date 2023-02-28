//	Class Örneği
//	--------------- Program.cs ---------------
using System;

namespace CLASS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            Ogrenci ogr2 = new Ogrenci();

            ogr1.yas = 15;
            ogr1.isim = "Tayfun";

            ogr2.yas = 25;
            ogr2.isim = "Kutay";

            ogr1.yazdir();
            ogr2.yazdir();

            Console.ReadKey();
        }
    }
}

//	--------------- Ogrenci.cs ---------------

using System;

namespace CLASS
{
    internal class Ogrenci
    {
        public int yas;
        public string isim;

        public void yazdir()
        {
            Console.WriteLine("{0}.....{1}", yas, isim);
        }
    }
}

// NOT: 
	Ogrenci ogr4;
	ogr4.yazdir();
	
// Şeklinde kullanamayacağımızı daha önce belirtmiştik. Visual Studio zaten hata verecektir.
// new operatörü kullanıp bir nesne oluşturmadığımız için.

// Bu şekilde bir referans oluşturmak aslında.
	Ogrenci ogr4 = null;
// ifadesi ile aynı şeydir.

// NOT 2:
	new Ogrenci();

// Şeklinde oluşturduğumuz nesne ise tek başına bir anlam ifade etmemektedir. Çünkü bir referansı yoktur.
// Otomatik olarak temizlenir ve kaybolur.