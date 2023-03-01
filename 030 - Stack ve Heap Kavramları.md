### Stack ve Heap Kavramları

Stack ve Heap kavramlarından kısaca bahsetmek gerekirse, ram’in mantıksal bölümleridir diyebiliriz. Stack’de değer tipleri, pointer ve adresler saklanırken, Heap’de ise referans değerleri saklanmaktadır.

Stack’e erişim Heap’den daha hızlıdır ve Stack, LIFO (Last-In-First-Out) mantığında çalışmaktadır. Yani son gelen ilk olarak çıkar. Bu sebep ile aradan herhangi bir eleman çıkartamazsınız, birbirleri ile ilişki içerisindedirler.

Struct tipindeki değişkenler değer tipleridir ve Stack içerisinde saklanmaktadır. Class tipindeki değişkenler ise referans tipleridir ve referansları Stack’de kendisi ise Heap’de saklanır.

![](https://i.imgur.com/Vjg2ND4.png)

Örneğin yukarıdaki şekilde görüldüğü üzere Int değer tipinde olduğu için direk Stack üzerinde “000001” adresine yerleştirilmiştir. String ise referans tipinden bir değişken olduğu için Stack üzerinde “00000H” adresinde ve “FFF0GH” olarak referans adresi tutulmuştur.

- Stack & Heap’in genel özelliklerine kısaca bir bacak olursak;
- Stack ve Heap ram’in mantıksal bölümleridir.
- Stack LIFO mantığında çalışır. Yani son gelen ilk olarak çıkar.
- Stack’de değer tipleri, pointer ve adresler saklanırken Heap’de ise referans değerleri saklanır.
- Stack daha hızlıdır. Ulaşılmak istenen veriler ard arda sıralanmış olur.
- Heap ortak olarak kullanılır ve uygulama başlatıldığında başlar.

> NOT:  ref anahlar kelimesi ile bir method’a değer tipi dahi yollasak, (yukarıda bahsettik değer tipleri Stack üzerinde tutulmaktadır) söz konusu değişkenin içeriğini Stack bölgesinden Heap bölgeye aktarır ve adresini ise Stack bölgesindeki alanına yazar.