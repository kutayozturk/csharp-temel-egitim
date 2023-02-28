/* METOTLAR (FONKSİYONLAR)
	Bilgisayar programlama dillerinde bir veya birden çok eylemi
	gerçekleştirmek için yazılan ve ana programa parametre ve
	fonksiyon dönüş değeri ile bağlı olan alt programdır.
	
	Fonksiyonlar modüler program yazmak için kullandığımız bir yöntemdir.
	Bu yöntem ile sorunları küçültmüş oluruz, aynı kod parçasını
	lazım olan noktalarda çağırarak, işlem yaptırabiliriz.
	
	İki türlü Metot vardır.
	1. Adıyla geriye değer gönderen Metotlar (retrun eden)
	2. Adıyla geriye değer göndermeyen Metotlar (void fonksiyonlar)
	
	Şimdi tek tek inceleyelim.
	1. Adıyla geriye değer retrun eden Metotlar
	
	veritip1 metotAdi (veritipi2 parametreadi1, ....) {
		yerel tanımlar (sadece bu fonksiyon için geçerli)
		komutlar
		EN AZ BİR TANE RETURN 
			(if else durumuna göre birden fazla
			farklı değer döndürülebilir.)
			
			NOT: Geriye bir tane return dönecektir ama
			kod içersinden birden fazla return kullanabilirim.
	}
	
	return: Üretilen değeri çağıran yere geri gönderdirir.
	NOT: Çağıran yer: main fonksiyon çağırdığı gibi, başka bir fonksiyonda
	yine bir fonksiyon çağırabilir.
	


	veritipi1: fonksiyonun üreteceği sonucun veri tipidir.
	fonksiyonadi: çağırma aşamasında kullanılan isim
	veritipi2: parametredeki değişkenin veri tipidir
	parametreadi: fonksiyonun çalışması için gereken değerleri KARŞILAYAN değişkenlerdir.+
	
	BU FONKSİYONLARIN ÇAĞRILIŞI
	
	Adıyla geriye değer gönderen fonksiyonlar,
	ancak ve ancak bir başka komutun içinden çağrılırlar.
	
	Örneğin;
	*/
		class Program
    {
        private static int Hesapla(int kisa,int uzun) // Hesapla adında 2 adet int tipte değişken alan bir metot oluşturduk
        {
            int alan = kisa * uzun;
            return alan;
        }
 
        static void Main(string[] args)
        {
            Console.Write("Kısa kenarı girin :");
            int kk = Convert.ToInt32(Console.ReadLine());
			
            Console.Write("Uzun kenarı girin :");
            int uk = Convert.ToInt32(Console.ReadLine());
			
            int sonuc = Hesapla(kk,uk);
            Console.WriteLine("Alan = "+ sonuc);
			
            Console.ReadKey();
        }
    }
		
	/*
	Örnekler:
	1. bir sayının faktöryelini bulan...
	2. bir sayının asal olup olmadığını bulan...
	3. n elemanlı bir dizinin ortalamasını bulan...
	
	Yanlış Örnekler:
	1. ikinci dereceden denklemin köklerini bulan...
	2. Ekrana "Naber" yazan...
	3. Bir dizinin en küçük değerini ve indisini bulan...
	*/