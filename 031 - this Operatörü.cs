// this Operatörü

class Calisan
{
	public int yas;
	public int maas;
	
	public void veriGir(int yas, int maas)
	{
		yas=yas;
		mass=maas;
	}
}

/*
Yukarıda görüldüğü gibi, argüman isimleri ve değişken isimleri birbirinin aynısıdır.
Bu durumda class'da tanımlanan "yas" ile fonksiyon argümanı olan "yas" ifadesi birbiri ile olduğunda
ve yukardaki eşitleme yapıldığında, değer ataması kime yapılıyor?
	Böyle bir durumda fonksiyon argümanı atamayı kendisine yapar.
	Nesenin "yas" ve "maas" değişkenlerine yapılmaz.
	Çünkü programlamada son tanımlanan değişkenin önceliği vardır.
	
NOT: (Visual Studio'da yukarıdaki örneği yazdığınızda "yas=yas" ifadesinin altını yeşil olarak çizecektir.
Yeşil çizgi, uyarı demektir. ) Ayrıca renklerdirmenin aynı olduğunu göreceksiniz.
	
	Bu sorunu çözmek için "this" isimli operatorü kullanırız.
*/
	
class Calisan
{
	public int yas;
	public int maas;
	
	public void veriGir(int yas, int maas)
	{
		this.yas=yas;
		this.mass=maas;
	}
}

/*
this operatörü, nesnenin referansını tutar. Dolayısıyla sorun ortadan kalkmış olur.
Oluşturulan nesnenin referansını tutar ve elemanlara erişmemizi sağlar.

this operatorünü metodlarda da kullanabilirsiniz.

this operatörü kullanımı zorunlu değildir. Programcının tercihidir aslında. Kullanılması mantıklıdı.
Ayrıca aşağıdaki gibi bir çözümde sağlanabilir. "_" veya "m" ekini kullanabilirsiniz.
*/

class Calisan
{
	public int _yas; 	// _yas olarak tanımlanmıştır.
	public int mMaas;	// member (üye) anlamına gelen "m" harfi değişkenin başına eklenmiştir.
	
	public void veriGir(int yas, int maas)
	{
		_yas=yas;
		mMass=maas;
	}
}
