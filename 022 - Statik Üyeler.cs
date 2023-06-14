/*
Statik Üyeler
 *- Metotlar

- Statik metotlar ait oldukları sınıftan bir nesne oluşturmadan kullanılabilirler.
- Örneğin Console.WriteLine statik bir metotdur.

*/

Statik Metot Tanımlama

class Matematik
{

	public static int UstAl(int taban, int ust)
	{
	int sonuc=1;
	for(int i=1;i<ust;i++)
		sonuc*=taban;
		
		return sonuc;
	}

}

Main Program

static void Main(string[] args)
{
	int sonuc = Matematik.UstAl(2,6); // çağırır iken "." ifadesi ile ait olduğu sınıftan çağırdık.
	
	Console.WriteLine(sonuc);

}


Statik Değişkenler nesnelerden bağımsızdır. Sınıfa aittir. int tipteki bir static değişkene ilk değer olarak 0 değeri atanır. Statik değişkenler, nesnelere ba
ğımlı olmadığı için, bütün nesneler bu değişkenin değerini aynı olarak görür. Çünkü bütün nesneler static değişkeni tanır. Bunun avantajı ise tam olarak şudur. Bütün nesnelerin ulaşabileceği, tanıyabileceği, kullanabileceği bir değişken elde etmiş olduk.