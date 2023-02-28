/*	Enum Veri Tipi
C# programlama dilinde enum, sabitlerin kümelenerek birlikte daha anlamlı ve
kullanışlı olarak kullanımlasını amaçlayan bir veri tipidir.
Genel Yazılışı

Örnek 1: Günlerden oluşan bir enum aşağıdaki gibidir
*/
	enum Gunler { Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar };
	Gunler sali = Gunler.Salı;
	System.Console.WriteLine("Salı günü haftanın {0}. günüdür", (int)sali+1);

/*	Çıktı: Salı günü haftanın 2. günüdür

	Not: enum'larda index'ler sıfırdan başlar ve manuel olarak index'leme yapılmazsa otomatik olarak yapılır
*/

//	Örnek 2: enum'larda index'leri kendimiz de verebiliriz.

	enum Gunler { Pazartesi=1, Salı=2, Çarşamba=3, Perşembe=4, Cuma=5, Cumartesi=6, Pazar=7 };
	Gunler sali = Gunler.Salı;
	System.Console.WriteLine("Salı günü haftanın {0}. günüdür", (int)sali);

//	Çıktı: Salı günü haftanın 2. günüdür

 
//	Örnek 3:

	enum PismeDereceleri { AzPismis=50, OrtaPismis=55, CokPismis=60, Yanmis=70};
	System.Console.WriteLine("Orta pişmiş bir bifteğin derecesi {0} santigrattır", (int)PismeDereceleri.OrtaPismis);
// Çıktı: Orta pişmiş bir bifteğin derecesi 55. santigrattır