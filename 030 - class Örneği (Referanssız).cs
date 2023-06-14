//	Class Farklı Kullanımı

//	--------------- Ogrenci.cs ---------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

//	--------------- Program.cs ---------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            (new Ogrenci()).yazdir(); // Referansı olmayan bir nesne oluşturduk ve bu nesneyi kullandık.
            Console.ReadKey();
        }
    }
}

// Ekran Çıktısı:	0.....


