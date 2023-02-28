using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Köpeğin var mı: ");
			bool varMi = Convert.ToBoolean(Console.Readline());
			// bool varMi = bool.Parse(Console.Readline()); //	Diğer bir veri tipi dönüştürme yöntemi
			
			/* 
			Parse komutuda temelde Convert ile aynı işi yapar. 
			Aralarındaki farkı inceleyelim.
			
			int.Parse ve Convert ToInt32, bir dizgiyi bir tamsayıya dönüştürmek için iki yöntemdir.
			C# dilinde int Parse ve Convert ToInt32 arasındaki temel fark, int Parse'a boş bir değer iletildiğinde bir ArgumentNullException oluştururken,
			Convert ToInt32'ye boş bir değer iletildiğinde sıfır verir.
			*/

            Console.ReadLine();
			
        }
    }
}
