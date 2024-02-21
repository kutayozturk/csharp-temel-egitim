
using System.Data;
using System.Reflection.PortableExecutable;

class TestClass
{
    static void Main(string[] args)
    {
        
#region Value Type (Değer Tipleri)

int numberA = 5; // integer tipinde number1 adında, içerisinde 5 değerini tutan değişken.
Console.WriteLine("Number 1 degeri : {0}", numberA); // Formatlı gösterim modelinde {} ifadeleri arasına değişkenlerin index numarası (Bilgisayar saymaya 0'an başlar. Bu numaralandırma işlemine index denir.) virgülden sonraki değişkenleri bu indise göre çeker. Örneğin:
Console.WriteLine();

int numberB = 7;

Console.WriteLine("Number A ve B degerleri sirasiyla {0} ve {1}", numberA, numberB);
Console.WriteLine();

int deger = 1000000000; // Bütün veritiplerinin bir değer aralığı vardır. Örneğin integer (tamsayı) değerlerinin aralığı -2147483648 ile 2147483647 arasındadır. 
// int veri tipi 32 Bit'tir.
Console.WriteLine("int Değer: {0}", deger);
Console.WriteLine();
//int deger2 = 10000000000; // Görüldüğü üzere değer sınırı aşıldığında editörümüz bizi uyarıyor.

#endregion

#region //Long Veri Tipi
// long veri tipi integer'ın tam 2 katı kadar değeri tutar, bu sebeple long içerisinde aslında int veri tipini kendi bünyesinde barındırır. Ancak RAM içerisinde'de 2 katı kadar alan ayrılmış olur. Bu nedenle int yerine long kullanalım diyemeyiz.
// long veri tipi 19 karaktere kadar desteklemektedir.
// long veri tipi 64 Bit'tir.
// long değer aralığı: -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807


long numberC = -922337203685477580;


#endregion

#region // short veri tipi
// short veri tipi 16 Bit'lik değeri hafızasında tutar.
// Değer Aralığı: -32.768 ile 32.767

short degerShort = 32767;
Console.WriteLine("Short değeri: {0}", degerShort);
Console.WriteLine();
#endregion

#region // Byte Veri Tipi
byte numberByte1 = 0;
byte numberByte2 = 255;

Console.WriteLine("Byte1: {0} ve Byte2: {1}", numberByte1, numberByte2);
Console.WriteLine();
// byte 0 ile 255 arasında değer alabilir. Negatif değerler alamazlar.
#endregion

#region // bool (boolean) Değer tipi 
// içerisinde True veya False değer tutar. 

bool degerBool1 = true;
bool degerBool2 = false;
Console.WriteLine("Değer 1: {0} | Değer 2:{1}", degerBool1, degerBool2);
Console.WriteLine();
#endregion

#region // char Değer Tipi
// char değişkeni içerisine tek bir karakter alabilir. Tanımlama 'TEK TIRMAK' arasına ilgili KARAKTER'in yazılması ile gerçekleştirilir. 

char karakter = 'A';
// char isim='Kutay';   // Hatalı bir kullanımdır.
// char rakam=65;  // Hatalı bir kullanımdır. Bu şekilde ASCII Kod Tablosuna erişim sağlanamaz.

Console.WriteLine("Girilen Karakter Değeri: {0}", karakter);
Console.WriteLine();

// ASCII Kod Tablosundali karakterin değerine ulaşmak istiyorsak:
char karakterDegeri = 'B';
Console.WriteLine("Karakter Değeri: {0}", (int)karakterDegeri);
Console.WriteLine();
#endregion

#region // Double Veri Tipi
// double veri tipi ondalıklı sayıları tutmak için vardır. içerisinde int değerleri barındırır. Çünkü 5 ile 5.0 aslında matematiksel olarak aynı şeydir.
// 64 Bit'lik veri  tipidir.
// Değer Aralığı: 1,7E +/- 308 (15 basamak)

double numberDoubleA = 5.19;
double numberDoubleB = 3.97;
double numverDoubleC = 9;


Console.WriteLine("Double A: {0} | Double B: {1} | Double C: {2}", numberDoubleA, (int)numberDoubleB, numverDoubleC);

// Yukarıdanda anlaşılacağı üzere double bir değişken, int formatına dönüştürüldüğünde YUVARLAMA işlemi YAPMAZ!
Console.WriteLine();

#endregion

#region // Decimal Veri Tipi
// decimal veri tipi, double veri tipinin genişletilmiş halidir. double veri tipi 15 karaktere kadar değer tutabilirken, decimal değişkeni 28 karaktere kadar değer tutabilir.

decimal numberDesimalA = 10.5m;
decimal numberDesimalB = 27.89M;
decimal numberDesimalC = 18;

// Decimal veri tipleri doğrudan ondalık sayı değeri alamazlar. Değerin sonuna "m" yada "M" harrfi eklenmelidir.

// Decimal veri tipileri içerisine tam sayı bir değer atanacaksa, direkt olarak değer tanımlanabilir.

Console.WriteLine("Desimal A: {0} | Desimal B: {1} | Desimal C: {2}", numberDesimalA, numberDesimalB, numberDesimalC);
Console.WriteLine();

// Enum'dan gelen değerler


Console.WriteLine("Seçilen Gün: {0}",Gunler.pazar);
Console.WriteLine();

Console.WriteLine("Seçilen Gün index Numarası: {0}",(int)Gunler.persembe);
Console.WriteLine();

#endregion
        
    }
}

#region // Enum Veri Tipleri

enum Gunler
{
    pazartesi,
    sali,
    carsamba,
    persembe,
    cuma,
    cumartesi,
    pazar
}

// enum veri tipleri aslında kendi değişkenlerimizi üretmemize yarayan, index mantığı ile çalışan bir yapıdır.

#endregion