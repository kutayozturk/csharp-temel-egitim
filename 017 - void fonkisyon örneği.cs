// ekranaYaz adında geriye değer döndürmeyen bir Metot oluşturalım.


class Program
    {
        static void Main(string[] args)
        {
            string ad = "Kutay"; // isim tanımladık
            ekranaYaz(); // main içerisinde çağrılırken "Adıyla" çağrılırlar.
            isimSor(ad);
        }

        static void ekranaYaz() // void tipinde bir fonkisyon oluştuduk, içerisine herhangi bir argüman almadı
        {
            Console.WriteLine("Merhaba");
        }

        static void isimSor(string isim) // string tipinde isim değişkeni alan isimSor fonksiyonu
        {
            Console.WriteLine("Hoşgeldin, " + isim);
            Console.ReadLine();
        }
    }
	
	
	