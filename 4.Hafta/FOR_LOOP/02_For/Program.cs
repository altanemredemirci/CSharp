using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak bir sayının faktöriyelini hesaplayan for dönügüsü

            // 5 => 1*2*3*4*5=120

            Console.WriteLine("faktöriyel hespalayanacak sayı: "); //5
            int sayi = Convert.ToInt32(Console.ReadLine());

            int fakt = 1;

            //for (int i = sayi; i >0; i--)
            //{
            //    fakt = fakt * i;
            //}


            for (int i = 1; i <= sayi; i++)
            {
                Console.WriteLine($"{fakt}*{i}={fakt*i}");
                fakt *= i;
            }

            Console.WriteLine("faktöriyel:"+fakt);


            Console.ReadLine();

        }
    }
}
