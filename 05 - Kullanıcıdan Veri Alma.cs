//	C# 'da Kullanıcıdan Veri Alma
	// 1. Yöntem
		Console.WriteLine("Kullanıcı adını giriniz: ");
		string isim = Console.ReadLine();
		Console.WriteLine("İsim: " + isim); // + Operatörü ile "İsim:" yazısının yanına, kullanıcıdan alınan veri eklenmiş oldu.
	
	/* 
	Ekran Çıktısı
		Kullanıcı adını giriniz: Kutay
		İsim: Kutay
	*/
	
	// 2. Yöntem
		Console.WriteLine("Kullanıcı adını giriniz: ");
		string isim = Console.ReadLine();
		Console.WriteLine($"İsim: {isim}"); // $ işareti ile kullancıdan alınan veri hafızada tutulmuştur.
		// Burada "isim" değişkeninin {ARASINDA} olduğuna dikkat ediniz.
	
	// 3. Yöntem (Formatlı Gösterim)
		 Console.WriteLine("Kullanıcı adını giriniz: ");
         string isim = Console.ReadLine();
         Console.WriteLine("Kullanıcı Soyadını giriniz: ");
         string soyad = Console.ReadLine();

         Console.WriteLine("İsim: {0} Soyad: {1}", isim, soyad); // Kullanıcıdan alınan "isim" ve "soyad" değişkenleri index numaraları kullanılarak yazdırılmıştır.

         Console.ReadLine(); // Ekran kapanamsın diye bilerek ekledik.
	
