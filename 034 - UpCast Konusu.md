# UpCast Konusu
Upcasting alt sınıftan oluşturulmuş bir nesneyi üst sınıftan oluşturulmuş bir nesneye çevirmek.
> Temel sınıf referansı ile türetilmiş nesnelere erişim) olarakda adlandırabiliriz

Upcasting aslında biz programcıları çok sık kullandığı bir yöntemdir. Kod yazmadan önce bir görsel ile UpCastin işlemini anlamaya çalışalım.

![](https://i.imgur.com/RniEdtR.png)

Yukarıdaki görseli incelediğimizde; **"x"** ve **"y"** değerleri sekil1 isimli sınıfa aittir. **kare1** isimli sınıf, **sekil1** isimli sınıfı içerisinde barındırmaktadır. **sekil1** içerisinde **"boyut"** değişkeni yer almamasına karşın, kare1 sınıfı içerisinde yer aldığından, **kare1** içerisinde hem **sekil1 sınıfı** kullanılabilir, hemde **"boyut"** isimli değişken kullanılabilir. 

**Upcast (Yukarı Dönüşüm)** olarak gösterilmiştir.
 
```
using Internal;
using System;

namespace UpCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare();
            Sekil sekil1 =  kare1;
        }  
    }

    class Sekil{
        public int x;
        public int y;

        public void yazdir(){
            Console.WriteLine(x + "," + y +);
        }
    }

    class Kare:Sekil{
        public int boyut;
        public int AlanHesapla(){
            return boyut*boyut;
        }
    }
}

```
Ekran Çıktısı:
````
15,3
45
````

şeklinde olacaktır.
