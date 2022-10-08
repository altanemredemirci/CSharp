using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DO_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 1-10 arasında bir sayı alınız.

            //while (true)
            //{
            //    Console.WriteLine("1-10 arasında bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi < 11 && sayi > 0)
            //    {
            //        Console.WriteLine(sayi);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("HATA!!");
            //    }
            //}
            //int sayi;

            //do
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    sayi= Convert.ToInt32(Console.ReadLine());

            //} while (sayi>10 || sayi<1);


            //Console.WriteLine(sayi);

            bool durum = false;

            do
            {
                Console.WriteLine("DURUM:" + durum);
            } while (durum==false); //(!durum);


            Console.ReadLine();
        }
    }
}
