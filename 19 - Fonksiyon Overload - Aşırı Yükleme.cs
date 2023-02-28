class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 Değerli Toplama işlemi sonucu: " + topla(2, 3)); // 2 ve 3 değerlerine sahip parametleri kullandık
            Console.WriteLine("2 Değerli Toplama işlemi sonucu: " + topla(2, 3, 4)); // 2, 3 ve 4 değerlerine sahip parametleri kullandık

            Console.ReadLine();
        }

        #region Fonksiyon Overload
        /* Fonksiyon Aşırı Yüklemesi olarakta tanımlanır.
        Bu yöntem aynı isimle, birden fazla fonksiyon tanımlamıza ve kullanmamıza olanak sağlar.

        Aynı isimle fonksiyon oluştururken, aldığı parametre SAYILARI farklı olmalıdır.
        Farklı sayıda parametre olmayacaksa, FARKLI TİPTE PARAMETRE almaları gerekir.

        */
        static int topla(int a, int b) // int tipinde geriye değer döndüren topla isimli 2 parametreli fonksiyon.
        {
            a = a + b;
            return a;
        }

        // Aynı isimde farklı sayıda parametre alan fonksiyon örneği
        static int topla(int a, int b, int c) // int tipinde geriye değer döndüren topla isimli 3 parametreli fonksiyon.
        {
            a = a + b + c;
            return a;
        }

        // farklı tipe değer döndüren, aynı isimdeki fonksiyon
        static int topla(string a, int b) // int tipinde geriye değer döndüren topla isimli 2 parametreli fonksiyon.
        {
            b = 2 + b;
            return b;
            // a değişkeni bir string değişken olduğundan işleme tabi tutmadık.
            // Çıktı olarak int beklyiroz çünkü.
            // sadece yapılabildiğini anlatmak için eklenmiştir.
        }

        #endregion

    }