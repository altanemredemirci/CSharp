using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan değerleri arasındaki sayıları ekrana yazdırınız.

            #region ÇAM
            //Console.WriteLine("başlangıç değerini giriniz: ");
            //int baslangıc = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("bitiş değerini giriniz: ");
            //int bitis = Convert.ToInt32(Console.ReadLine());



            //while (baslangıc < bitis)
            //{
            //    Console.WriteLine(baslangıc);
            //    baslangıc++;
            //}
            //Console.ReadLine();

            #endregion

            #region HÜSEYİN
            //Console.WriteLine("birinci sayıyı giriniz");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ikinci sayıyı giriniz");
            //int b = Convert.ToInt32(Console.ReadLine());

            //if (a < b)
            //{
            //    while (a < b)
            //    {
            //        Console.WriteLine(a);
            //        a++;
            //    }


            //}
            //else
            //{
            //    while (b < a)
            //    {
            //        Console.WriteLine(b);
            //        b++;
            //    }
            //}

            #endregion


            Console.WriteLine("başlangıç değerini giriniz: ");
            int baslangıc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bitiş değerini giriniz: ");
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (baslangıc > bitis) // bas=10 bitis=100
            {
                int sayi = baslangıc;
                baslangıc = bitis;
                bitis = sayi;
            }

            while (baslangıc < bitis)
            {
                Console.WriteLine(baslangıc);
                baslangıc++;
            }
        }
    }
}
