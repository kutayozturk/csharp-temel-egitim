/*
Do-while döngüsü koşulun doğruluğunu kontrol etmeden en az bir kere çalıştırılması istenilen durumlarda kullanılmaktadır.

Do while döngüsü while döngüsüne benzemektedir.
Fakat aralarında ufak bir fark vardır.
Bu fark while döngüsü koşulun doğruluğunu başta kontrol eder, do-while döngüsünde koşul yanlış olsa bile bir kez çalışır.

Genel Yazılışı
do {

//yapılacak işlemler;
//arttırma veya azaltma işlemi

} while(koşul);

	Örnek
*/

int i = 5; // i isimli int veri tipi tanımladık ve başlangıç değerini 5 olarak belirledik

do
{
 Console.WriteLine(i); // i değerini ekrana yazdırdık
 i++; // i değerini 1 arttırdık

} while (i<4); // i değerinin 4'ten küçük olup olmadığını kontrol ettirdik.
// Bu örnekte i değeri 5 olduğundan ve 4'ten küçük olduğundan, do-while döngüsü gereği ekrana bir kez 5 ifadesi yazıldı
// sonra koşul sağlanamdığı için döngüden çıkıldı.

Console.ReadLine();
