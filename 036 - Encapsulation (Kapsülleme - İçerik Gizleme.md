## Encapsulation (Kapsülleme - İçerik Gizleme)
- Üreticiler, kullanıcıların ürünlerin iç dizaynına erişmeden kullanabilmesini isterler.
- Örneğin bir televizyon kumandası, dışında bulunan tuşlar aracılığıylşa kontrol edilebilmektedir. Kullanıcının kumandanın içeriğini bilmesine gerek yoktur.
- Bu sayede kumandaların i. dizaynı değişse bile, kullanım şekli değişmediği için kullanıcının herhangi bir yeni bilgiye ihtiyacı olmaz.
- Bir kapı zili düşünelim. Her bir zilin iç dizaynı birbirinden farklı olabilir fakat hepsi aynı şekilde çalışmaktadır. Böylece zillerin çalışma prensibi değişsede kullanım şekli aynı kalır.

---
- Yazılımcı olarak tasarlardığımız sınıfların belirli kısımlarını, sınıfları kullanacak olan programcılardan saklamak isteyebiliriz. (private kullanmak gibi)
- Bunun temel sebebi ilerleyen zamanalrda bu kısımların yeniden yazılması (geliştirilmesi veya hatalarının düzeltilmesi için) gerekebilir.
- Kullanıcılar tasarladığımız sınıfların iç dizaynını kullanmadıkları için yaptığımız değişimler onların kodunu etkilemeyecektir. ***(20 yıl önce çıkmış olan bir bilgisayar oyunu düşünün. Bu oyun dirext ile çalışıyor diyelim. (OpenGL'de var) Şuanda bu oyunu bilgisayarınıza yükleseniz oynayabilirsiniz. Dirext sürümü güncellenmiş olsa bile. Çünkü diretx'in iç dizaynı değiştirilmemiştir. Sadece gerekli noktalara dokunulmuş olmasındandır.)***

![](https://i.imgur.com/UnK8Wy4.png)
![](https://i.imgur.com/h9P8l3w.png)
> :warning: Erişilebilir olan nesneleri **public** olarak tanımlıyoruz.

---
### get ve set
- Bazı durumlarda iç dizayn olarak oluşturduğunuz değişkenlerin kullanıcı tarafından erişilebilir olmasını isteyebilirsiniz. ***(Direkt olarak değil, bir arabulucu ile)*** Bu durumda sınıftaki **private** ve **protected** elemanlara değer atamak veya değerlerini okumak için **get ve set** metotları kullanılabilir.


> :star: **Hatırlatma**
get: değeri getirmek, okumak için,
set: değer atamak için kullanılır.

```
class Ogrenci
{
    private int yas = 25;

    public int Yas; // dışarıdan erişilebilir olsun istedik
    {
        get // get metodu çağrıldığında "yas" değişkeninin değerini döndürür.
        {
            return yas;
        }
    }

}
```

Main içerisine bir tane **ogr nesnesi** oluşturalım.
```
statci void Mani(string[] args)
{
    Ogrenci ogr = new Ogrenci();

    // Console.WriteLine(ogr.yas); // .yas kullanımda hata verecektir.
    Console.WriteLine(ogr.Yas); // burada ise .Yas değerini gördüğü için derleyici hemen "get" metoduna gider ve "yas" değeri return edildiği için değeri getirir. (public olduğu için çağırabilir)

}
```
Aynı işlem değer atamak içinde kullanılabilir. Bu sefer **"set"** metodunu yazalım.

```
class Ogrenci
{
    private int yas = 25;

    public int Yas; 

        get  
        {
            return yas;
        }

        set
        {
            yas = value;
        }
}
```

Main içerisindeki kodlarımız
```
statci void Mani(string[] args)
{
    Ogrenci ogr = new Ogrenci();

    ogr.Yas = 34; // set metodu ile değer ataması yapılmıştır.
    
    Console.WriteLine(ogr.Yas);

}
```