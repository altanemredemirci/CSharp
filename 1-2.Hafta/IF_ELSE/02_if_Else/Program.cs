using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayı 100'den büyük ise ekrana büyüktür, küçük ise küçüktür yazdıran if else bloğu. 

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 100)
            {
                Console.WriteLine("100'den büyüktür");
            }
            else if (sayi == 100)

                Console.WriteLine("Sayı 100'e eşittir.");


            else
            {
                Console.WriteLine("100'den küçüktür.");
            }

            Console.ReadLine();
        }
    }
}
