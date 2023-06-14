/* C#'da namespace Kullanımı


namespace'ler projelerde aynı isimlerin, farklı ekipler tarafından kullanılabilmesi için geliştirilmiştir.
Örneğin A Yazılımcısı ve B Yazılımcısı aynı proje üzerinde çalışıyor olsunlar.
Her iki yazılımcı birbirlerinden habersiz şekilde, aynı isim ile class, method vb. yapılar oluşturabilir
hatta aynı değişken isimlerini bile kullanabilirler. 

Bu durum, bu kodlamalar proje içerisine bu aktarıldığı zaman hatalara neden olacaktır.
Bunun önüne geçmek için, farklı namespace'ler oluşturularak düzeltilebilir.

namespace'ler class'lar gibi dışarıda da oluşturulabilir. Ancak, kullanılmak istenilen kod sayfası içerisine
eklenmeleri gereklidir.

	using Lisans;
	using YuksekLisans;
	
Bu örnekte yukarıdaki gibi eklenmişlerdir.

*/

//	------------- Lisanslar.cs -------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisans
{
    internal class ogrenci
    {
        public int _yas;
        public int _ogrNot;

        public void veriGirisi(int yas, int ogrNot)
        {
            _yas = yas;
            _ogrNot = ogrNot;
        }
    }
}

namespace YuksekLisans
{
    internal class ogrenci
    {
        public int _yas;
        public int _ogrNot;

        public void veriGirisi(int yas, int ogrNot)
        {
            _yas = yas;
            _ogrNot = ogrNot;
        }
    }
}

// Her iki yazılımcı, aynı adlara sahip Class ve Method oluşturmuştur.

//	------------- Program.cs -------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lisans;		// Lisans adlı namespace eklenmiştir.
using YuksekLisans;	// YuksekLisans adlı namespace eklenmiştir.

namespace CLASS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Lisans.ogrenci ogr1 = new Lisans.ogrenci();				// ogr1 adındaki referans, Lisans.ogrenci sınıfını kullanmaktadır. 
            YuksekLisans.ogrenci ogr2 = new YuksekLisans.ogrenci();	// ogr2 adındaki referans, YuksekLisans.ogrenci sınıfını kullanmaktadır. 
			
			/* NOT:
				ogrenci ogr1 = new ogrenci();
			Şeklinde kullanamayız. Çünkü ilgili nesne her iki namespace altında da yer almaktadır. Hangisinden oluşturması gerektiğini yukarıdaki
			gibi belirtmemiz gerekmektedir.
			
				Lisans.ogrenci ogr1 = new Lisans.ogrenci();	
			Lisans namepace'ine ait, ogrenci sınıfının ogr1 referansı
			
			*/

            Console.ReadKey();
        }
    }
}