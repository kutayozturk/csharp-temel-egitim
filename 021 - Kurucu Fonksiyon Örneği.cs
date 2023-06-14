// Kurucu Fonksiyon Örneği

class Kare
{

	private int x, y;
	private int boyut;
	
	public Kare()
	{
		Console.WriteLine("Kare() Çağrıldı");
				
		x=10;
		y=20;
		boyut=30;
		
	}
}

Öneri: Bir programlamacı olarak, sınıfa (class) ait olan üyeler, değişkenler kesinlikle private olmalıdır. Bunların dışarıya erişimi kesinlikle yasak olmalıdır.