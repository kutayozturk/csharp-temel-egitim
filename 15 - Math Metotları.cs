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

            /* Math kütüphanesi Metotları

            Abs( )
            Min( )
            Max( ) 
            Pow( ) 
            Round( )
            Sqrt( )
            BigMul( )
            Ceiling( )
            DivRem( )
            Sign( ) 
            Cos( ) 
            Sin( )
            Tan( ) 
            Acos( )
            Asin( )
            Atan( )
            */

            // Abs()   Parametre olarak giriken sayının mutlak değerini almak için kullanılır
            /* Parametre olarak farklı veri türlerinde değer alabilmekte ve aldığı veri türünde
                değer geri döndürmektedir. Yani, int alıyorsa int, double alıyorsa double olarak değer döndürür.
            */
            Console.WriteLine(Math.Abs(-27)); // 27 Cevabını döndürür
            Console.WriteLine(Math.Abs(-5.8)); // 5.8 Cevabını döndürür 
			Console.ReadLine();

            // Min()   Parametre olarak girilen 2 sayının, küçük olanını döndüren metottur.
            Console.WriteLine(Math.Min(10, 12)); // 10 cevabını verir.
			Console.ReadLine();

            // Max()   Parametre olarak girilen 2 sayının, büyük olanını döndüren metottur.
            Console.WriteLine(Math.Max(10,12)); // 12 cevabını verir.
			Console.ReadLine();

            /* Pow()   Parametre olarak girilen 2 sayı vardır. Üst alma metodudur. 
                Yani, verilen birinci sayının, verilen ikinci sayı kadar çarpımını hesaplamak için kullanılır.
            */
            Console.WriteLine(Math.Pow(2,3)); // 2 üzeri 3 işlemini hesaplar ve 8 değerini verir.
			Console.ReadLine();

            /* Round()  Paramtere olarak verilen ondalıklı sayıyı en yakın tam sayıya yuvarlama işlemi yapmaktadır.
                Örneğin: 3.01 ise 3'e yuvarlar, 3.49 ise 3'e yuvarlar, 3.51 ise 4'e yuvarlar.
            */
            Console.WriteLine(Math.Round(3.47)); // 3 cevabını üretir.
            Console.WriteLine(Math.Round(3.79)); // 4 cevabını üretir. 
			Console.ReadLine();

            // Sqrt()   Karekök bulmak için kullanılır. Double türünde verilen sayının karekökünü double türünde geri döndürür.
            Console.WriteLine(Math.Sqrt(9)); // 3 cevabını üretir. 
			Console.ReadLine();

            // BigMul()  parametre olarak verilen 2 adet int tamsayının çarpımını,  long türünde geri döndüren metod'dur.
			Console.WriteLine(Math.BigMul(37, 28)); // 1036 cevabını döndürür.
			Console.ReadLine();

            /* Ceiling() parametre olarak verilen ondalıklı sayıyı yukarıya veya tamsayının aynısına yuvarlama işlemi yapmak için kullanılmaktadır.
                 Bu metodda virgülden sonra 0'dan başka herhangi bir sayı olduğunda yukarı yuvarlama işlemi yapmaktadır.
            */
            Console.WriteLine(Math.Ceiling(3.01)); // 4 cevabını verir.
            Console.WriteLine(Math.Ceiling(3.00)); // 3 cevabını verir.
			Console.ReadLine();


            /* DivRem()    bölme işleminde bölümü bulmak için kullanılan metod'dur.
                Bölünen ve bölen girildiğinde geriye bölme işleminin sonucunu veren ve 3. parametre olarakta kalanı veren parametredir.
                Sayısal veri türlerinin tümünde kullanılabilir.
            */
			int kalan;
            int bolum = Math.DivRem(37, 12, out kalan);
            Console.WriteLine("Bölme işleminde Bölüm={0}, Kalan={1}", bolum, kalan);
            Console.ReadLine();
            /* Sign()   Sign metodu, parametre olarak verilen sayının negatif mi, pozitif mi, sıfıra eşit mi olduğunu bulmak için kullanılmaktadır. Geriye döndürdüğü değerler:

            0   : Geriye 0(sıfır) döndürdüğünde Sıfıra eşit demektir.
            1   : Geriye 1(bir) döndürdüğünde Pozitif demektir.
            -1  : Geriye - 1(eksi bir) döndürdüğünde Negatif demektir.
            */
			int sonuc = Math.Sign(24);

            switch (sonuc)
            {
                case 0: Console.WriteLine("Sayı Sıfıra Eşit"); break;
                case 1: Console.WriteLine("Sayı Pozitif"); break;
                case -1: Console.WriteLine("Sayı Negatif"); break;

                default: Console.WriteLine("Yanlış Değer Girildi"); break;
            }

            Console.ReadLine();


            /*Cos() parametre olarak verilen radyan açı değerini kosinüs olarak geri döndüren metod'dur. Kosinüs değerini Double olarak geri döndürmektedir.
                Bu metodu kullanabilmek için ilk önce derece olarak vereceğimiz açıyı radyana dönüştürmemiz gerekmektedir. 
                Bunun için Radyan = Derece * (π / 180) formülünü kullanmamız gerekir.
            */
			 for (double i = 0; i <= 180; i += 15)
            {

                double Radyan = i * (3.14 / 180);
                //verdiğimiz dereceyi radyana dönüştürüyoruz.

                double sonuc = Math.Cos(Radyan);
                Console.WriteLine(sonuc);
            }

            Console.ReadLine();


            // Sin()   parametre olarak verilen radyan açı değerini sünüs olarak geri döndüren metod'dur.  Sinüs değerini Double olarak geri döndürmektedir.
			for(double i=0; i<=180; i+=15)
			{

				double Radyan = i * (3.14 / 180);
				//verdiğimiz dereceyi radyana dönüştürüyoruz.

				double sonuc = Math.Sin(Radyan);
				Console.WriteLine(sonuc);
			}
						   
			Console.ReadLine();
            // Tan()   parametre olarak verilen radyan açı değerini tanjant olarak geri döndüren metod'dur. Tanjant değerini Double olarak geri döndürmektedir.
			for(double i=0; i<=180; i+=15)
			{

				double Radyan = i * (3.14 / 180);
				//verdiğimiz dereceyi radyana dönüştürüyoruz.

				double sonuc = Math.Tan(Radyan);
				Console.WriteLine(sonuc);
			}
					   
			Console.ReadLine();
			
            // Acos()  parametre olarak verilen kosinüs değerinin radyan açı değerini geri döndüren metod'dur. 
			double sonuc=Math.Acos(1);

			Console.WriteLine(sonuc);
					   
			Console.ReadLine();
						
            // Asin()  parametre olarak verilen sinüs değerinin radyan açı değerini geri döndüren metod'dur.			
			double sonuc=Math.Asin(1);

			Console.WriteLine(sonuc);

			Console.ReadLine();
			
            // Atan()  parametre olarak verilen tanjant değerinin radyan açı değerini geri döndüren metod'dur.
			double sonuc=Math.Atan(1);

			Console.WriteLine(sonuc);
					   
			Console.ReadLine();			

        }
    }
}
