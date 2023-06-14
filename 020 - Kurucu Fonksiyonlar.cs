/*
Kurucu (Yapıcı) Fonkisyonlar

Her bir nesne oluşturulduğunda, o nesneye ait bir kurucu fonksiyon otomatik olarak oluşturulmaktadır. Eğer biz bir kurucu fonksiyon yazmaksak, derleyici bizim yerimize gövdesi boş olan bir kurucu fonksiyon yazar.

Kurucu fonksiyonun görevi, nesne oluşturulduğunda nesnenin elemanlarına ilk değeri atamaktır.
- Kurucu fonksiyonlar ait oldukları sınıftan bir nesne oluşturulduğunda otomatik olarak çağrılan fonksiyonlardır.
- Ait oldukları sınıf (class) ile aynı isme sahiptirler.
*/


class Ogrenci
{

	public int yas;
	public int sinif;
	
	public Ogrenci() // Dikkat ederseniz kurucu fonksiyonların bir dönüş değer yoktur. (void vb. gibi)
	{
		Console.WriteLine("Kurucu");
	}

}
/*
Kurucu Fonkisyonların Aşırı Yüklenmesi

- Kurucu fonksiyonlar aşırı yüklenebilmektedir.
*/
class Ogrenci
{

	public int yas;
	public int sinif;
	
	public Ogrenci() // Dikkat ederseniz kurucu fonksiyonların bir dönüş değer yoktur. (void vb. gibi)
	{
		yas=15;
		sinif=2;
	}
	
	public Ogrenci(int yas, int sinif)
	{
			this.yas=yas;
			this.sinif=sinif;
	}
}
