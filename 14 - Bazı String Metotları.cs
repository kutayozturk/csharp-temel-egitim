// C# String Metotları

string sehirIsmi = "Ankara";

var sayi = sehirIsmi.ToArray(); // Array Dizi demektir. sehirIsmi string ifadesini, char dizisine dönüştürür
string sayi = sehirIsmi.Count(); // Count ifadesi toplam karakter sayısını verir
sehirIsmi.ToUpper(); // Tüm Karakterleri büyük harfe dönüştürür
sehirIsmi.ToLower(); // Tüm karakterleri küçük harfe dönüştürür
var t = sayi.Distinct(); // Tekrar eden değerleri Tekil göstermek için kullanılır.

string isim = "Kutay";
Console.WriteLine(isim.IndexOf('a')); // a karakterinin karşılaşıldığı ilk index değerini verir.
Console.WriteLine(isim.LastIndexOf('a')); // a karakterinin karşılaşıldığı son index değerini verir.
Console.WriteLine(isim.Replace('a','x')); // a karakterini x karakteri ile değiştirir. String ifadelerde de kullanılabilir.



