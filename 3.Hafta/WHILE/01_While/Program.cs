using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* LOOPS - DÖNGÜLER
             * For, While, Do-While, Foreach 
             
            * Tekrar eden kob satırları-işlemleri tekrar tekrar yazmaktan ve aynı kodları tekrar kodlamadan bizi kurtaran yazılım yapısıdır.


            ***** WHILE *****

            while(koşul==true)
            {
               // Kod bloğu (koşul true olduğu sürece bu blok çalışır.)
            }
             */

            // 1-10 arasındaki sayıları ekrana yazdırınız.

            int i = 1;

            while (i < 11) // döngünün kaç tur çalışacağını belirler.
            {
                i++;
                Console.WriteLine(i);               
            }



            //int j = 1;
            //while (j < 5)
            //{
            //    Console.WriteLine("Altan Emre DEMİRCİ");
            //    j++;
            //}


            Console.ReadLine();

        }
    }
}
