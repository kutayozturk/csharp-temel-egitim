### Garbage Collection (Çöp Toplayıcı)

```
static void Main() {string[] args)
{
    Ogrenci ogr1 = new Ogrenci();

        if(true)
        {
            Ogrenci ogr2 = new Ogrenci();
        }
}
```
Şeklinde bir kod yapımız olduğunu düşünelim.
Burada ***ogr1*** referansı **Stack**'te oluşturulurken, **Heap** bölümünde ***new Ogrenci();*** nesnesi oluşturulurmuştur.
.Net oluşturulan nesneler için referans sayısı tutar.

![](https://i.imgur.com/ljPSx1n.png)

.Net oluşturulan bütün nesneleri hiyeraşisinde tutar. Her nesneden haberi vardır. ***(Bu özellik .NET tabanlı diller için geçerlidir. C++ bu özelliğe sahip değildir.)***

```
static void Main() {string[] args)
{
    Ogrenci ogr1 = new Ogrenci();

        if(true)
        {
            Ogrenci ogr2 = new Ogrenci();

            if(true){

                Ogrenci ogr4 = new Ogrenci();

            }
        }
}
```
Yukarıdaki kod incelendiğinde 3 adet nesne oluşturulduğu görülmektedir.

![](https://i.imgur.com/Gw2i6Fj.png)

Görselden de anlaşılacağı üzere, Stack'te oluşturulan referans değerleri Heap'te nesneleri işaret etmektedirler ve görüldüğü üzere referans sayıları bu nesneler içerisinde tutulur ve şuan tüm referans sayıları "1" **(true)** olarak tutulmaktadır.

Kod yapımız bu durumdayken sadece ogr1 referanslı nesneyi oluşturduğumuzda;

```
static void Main() {string[] args)
{
    Ogrenci ogr1 = new Ogrenci();
}
```

![](https://i.imgur.com/lZdD3Vl.png)

Ogr2 ve Ogr4 referansları silindiğinde önce Stack alanından temizlenirler, daha sonra Heap içerisinde yer alan refereans sayıları "1" **(true)** değerinden "0" **(false)** değerine dönüştürülür.
.NET'te yer alan **Garbage Collector** ne zaman devreye girerse Heap alaında yer alan "0" referans numaralı nesneler ***Çöp toplayıcı*** tarafından temizlenir. 

![](https://i.imgur.com/I19wzOL.png)

Görüldüğü üzere ogr1 haricinde kodumuzdan temizlenen ogr2 ve ogr4 referansları artık olmadığından RAM'in son durumu bu şekilde olacaktır.

> **NOT:** Garbage Collector .Net tarafından devreye girer. Devreye girme zamanını bilemez ve ayarlayamayız. Otomatik olarak bu süreç çalıştırılır ve gerçekleştirilir.
