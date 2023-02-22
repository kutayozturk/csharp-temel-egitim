using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama işlemi sonucu: " + topla(2, 3)); // 2 ve 3 değerlerine sahip parametleri kullandık
            Console.ReadLine();
        }
        

        static int topla(int a, int b) // int tipinde geriye değer döndüren topla isimli 2 parametreli fonksiyon.
        {
            a = a + b;
            return a;
        }  
    }
}
