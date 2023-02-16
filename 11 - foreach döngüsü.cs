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
            /* 
            Foreach dögüsü
                dizi temelli dataların dolaşılması (itereid) edilmesi için kullanılır.
            
            Genel Yazılışı
            foreach(veri_türü değilken_adı in dizi_ismi)
                değişken ismi ekrana yazdırılır veya farklı işlemler yapılır.
            foreach döngüsü, dizinin tüm elemanlarına ulaşılmak istenildiğinde kullanılır.
            */

            string[] ogrenciler = new string[3] { "Kutay", "Ahmet", "Mehmet" };
            foreach (var student in ogrenciler)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();

            /* 
           2. Örnek
             int[] notlar= {100,50,85,90,25,45,37,75,87}; // notlar isimli int türünde bir dizi oluşturduk

            foreach (int not in notlar) //  notlar dizisini foreach içerisinde kullanmak için, tüm elemanlarına tek bir isim verdik (not) ismini 
            {

             if(not>=50 //  burada her bir elemanı 50 değerinde büyük mü veya eşit mi sorgusu ile sorguladık
             {
              Console.WriteLine(not+" :Notunuz İyi"); //    Cevabımız evet ise ekrana yazdırdık
             }
             else
             {
              Console.WriteLine(not+" :Notunuz Kötü");//    Cevabımız hayır ise ekrana yazdırdık
             }

            }
                 
             */
        }
    }
}
