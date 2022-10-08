using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-10 arasında rastegele bir sayı üretiniz

            //RANDOM KÜTÜPHANE

            Random r = new Random(); //Instance(Örneklem)

            int sayi = r.Next(); //0 ile intMaxValue bir sayı verir.


            //sayi = r.Next(10);

            sayi = r.Next(3, 9);
            
            Console.WriteLine(sayi);

            Console.ReadLine();
        }
    }
}
