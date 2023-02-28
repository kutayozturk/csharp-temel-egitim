/*

C# programlama dilinde while döngüsü programda verilen koşul sağlanıyor iken dönmeye devam eden döngülere while döngüsü denmektedir. Koşul yanlış olduğu durumlarda ise yani false olarak döndürüldüğünde döngü sonlandırılır.

Bilgi: While kelimesinin Türkçe anlamı iken demektir. Yani koşul sağlanıyorken devam et işlem yap demektir.

While Döngüsü Kullanımı ve Genel Yazılışı
while(koşul)

{

 yapılacak işlemler;

 Arttırma veya Azaltma işlemi

}
Bilgi: while döngüsünün içinde arttırma veya azaltma işlemi yapılmazsa döngü sonsuz döngü olur.

Örneğin
Ekrana 0123456789 yani rakamları yazan C# programının kodlarını while döngüsü ile yazalım.

*/

int i=0;

while(i<10)
{

 Console.WriteLine(i);

 i++;

}

