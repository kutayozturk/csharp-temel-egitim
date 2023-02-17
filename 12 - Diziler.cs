using System.ComponentModel;
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
           // Diziler
        // Tek boyutlu Diziler
        string[] isimler = {"Ayşe","Fatma"};
        string[] isimler2 = new string[15];
        isimler2[0] = "Mehmet";   

        // Çok boyutlu Diziler
        string[,] markaModel = new string[3,3];
        // yukarıda görüldüğü üzere çok boyutlu bir dizi yaratmak 
        // string[,] "," ifadesi ile gerçekleştirilir. "," sayısı ne kadar artarsa, dizi o kadar boyuta kavuşur.

        markaModel[0,0] = "BMW,M3";
        markaModel[0,1] = "BMW,M4";
        markaModel[0,2] = "BMW,M5";      

        markaModel[1,0] = "Honda,Civic";
        markaModel[1,1] = "Honda,Accord";
        markaModel[1,2] = "Honda,Jazz";   

        markaModel[2,0] = "Fiat,Doblo"
        markaModel[2,1] = "Fiat,500";
        markaModel[2,2] = "Fiat,Egea";


    /*  Eğer dizi elemanlarını belirli bir KARAKTER seçimi ile birbirinden ayırmak istersek
        Örneğin bu örnekte "," ifadesi bizim ayrım karakterimizi olsun

        string[a] = markaModel[2,2].Split(','); // Split komut ile dizimizin 2,2 noktasında bulunan elema
    */
        // foreach döngüsü ile dizideki tüm elemanlara ulaştık

        foreach (var item in markaModel)
        {
            Array.Resize(ref markalar, markalar.Length + 1);
            markalar[markalar.Length - 1] = item.Split(',')[0];
            

            Console.WriteLine(item); // Dizi elemanlarının tümünü ekrana yazdırdık
        }
        Console.ReadLine(); // Consol ekranını bekletmek için ekledik
        }

        
        
    }

 }
