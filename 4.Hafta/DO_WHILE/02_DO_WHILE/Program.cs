using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DO_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı 0 girene kadar bütün girdiği sayıları toplayalım. 0 girildiği zaman toplam değerini ekrana yazdıralım

            //int sayi,toplam=0;
            //do
            //{
            //    Console.WriteLine("Sayı:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;

            //} while (sayi!=0);






            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;

            //    if (sayi == 0)
            //        break;

            //} while (true);





            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //while (sayi != 0)
            //{
            //    toplam += sayi;

            //    Console.WriteLine("Sayı:");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //}


            Console.WriteLine("Sayı:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = sayi; i != 0; i+=0)
            {
                toplam += i;

                Console.WriteLine("Sayı:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Toplam:"+toplam);

            Console.ReadLine();
        }
    }
}
