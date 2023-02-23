// Parametre Adıyla Çalışma ve Varsayılan Parametre Ataması

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] karakterDizim = KarakterleriVer(sehir:"Paris",ulke:"Fransa");
            /* 
            Yukarıda yer alan (sehir:"Paris",ulke:"Fransa"); kısmına NamedPrameter denir. 
            Parametre ismini belirterek değer göndermemizi sağladı.

            Optional Parameter (Opsiyonel Parametre): Parametre değeri gönderilmezse, daha önceden belirlediğimiz bir paramatreyi
            varsayılan değer olarak gönderebiliriz.
            
            ---
                char[] karakterDizim = KarakterleriVer(ulke: "Fransa");
            
            Yukarıda yer alan kod parçasında görüldüğü gibi, "sehir" paramtresi gönderilmemiştir.
            "ulke" parametresi gönderilirken "ulke" etiketi ile gönderildiğinden, sehir ANKARA olarak kalır, ülke Fransa olarak
            değişecektir.

            NOT: parametre etiketi eklenmezse, ilk parametre değerini değiştirir.

                char[] karakterDizim = KarakterleriVer("Fransa");

            Bu örnekte Şehir, Fransa olarak değişmiş olacaktır.

             */

            foreach (var item in karakterDizim)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static char[] KarakterleriVer(string ulke="Türkiye", string sehir = "Ankara")
            // Yukarıda Optional Parameter kullanışmıştır. "=" operatörü ile varsayılan değerler eklenmiştir.
        {
            char[] karakterler = new char[ulke.Length + sehir.Length];
            for (int i = 0; i < ulke.Length; i++)
            {
                karakterler[i] = ulke[i];
            }
            for (int i = ulke.Length; i < sehir.Length + ulke.Length; i++)
            {
                karakterler[i] = sehir[i - ulke.Length];
            }
            return karakterler;
        }
    }
}