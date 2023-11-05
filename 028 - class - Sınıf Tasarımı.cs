/*OOP - Object Oriented Programming

Sınıf (class) nesnelerden oluşan geniş kapsamlı bir kod kombinasyonudur.
OOP ‘da (Nesne Yönelimli Programlama) nesne sınıfın özelliklerini barındıran küçük yapı taşıdır.
Yani biz bir sınıf yazarken çeşitli nesnelerin özelliklerini ve metodlarını bir arada toplarız.
Class aslında sadece bir tasarımdır.

NOT: C#'da genelde sınıf isimleri Büyük Harf ile başlar.
*/
//	Genel Yazılışı
	class Ogrenci
	{		
		veriler
	}

//	İçerisine metod yazılmış bir class'da üretebiliriz.
	class Ogrenci
	{		
		public int Yas;
		public string Ad;
		
		public void yazdir(){
			Console.WriteLine("{0} 'ın Yaşı {1}'dir",Ad,Yas);
		}
	}

/*	
Burada dikkat edilmesi gereken bir konuda şudur
	Yas ve Ad isimli değişkenler, direkt olarak kullanabiliyor. Herhangi bir şekilde biz parametre vermedik.
	class yapısının içerisinde olduğundan bu değerleri direkt olarak biliyor ve kullanabiliyor.
	
NESNE OLUŞTURMA
	Eğer ki class'tan bir nesne oluşturmak istiyorsanız, new operatörünü kullanmanız gerekiyor.
	Nesne oluşturmanın başka yolu yok. İllaki new operatörünü kullanmanız gerekmektedir.
*/	
	static void Mani(string[] args)
	{
		Ogreci ogr1 = new Ogrenci(); 
	/*	
			|		|
			|		|
			|		|
				
		    Referans	   Nesne Oluşturuldu	
		
		
		 Bir sınıf üretebilmek için, öncelikle onu bir REFERANSA atamamız gerekmektedir. Ogrenci class'ının ogr1 referansı
		 ogr1 oluşturulan nesneye erişmemizi sağlar. ogr1'in türü, Ogrenci sınıfı türünde.
	*/
	
	Ogrenci ogr2;
	ogr2 = new Ogrenci();
	
	// ile de aynı şeyi yapmış oluruz.	
	}
