using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan kaç adet ürün satın aldığını öğreniniz ve her ürünün fiyatını kullanıcıdan isteyerek toplam ödemeyi ekrana yazdırınız.

            #region HÜSEYİN
            //Console.WriteLine("kaç adet ürün aldınız"); //3
            //int adet = Convert.ToInt32(Console.ReadLine());
            //int b = 0;
            //double toplam = 0;
            //while (b < adet)
            //{
            //    Console.WriteLine("ürün fiyatını giriniz");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());

            //    toplam = toplam + fiyat;

            //    b++;
            //}
            #endregion


            //Console.WriteLine("kaç adet ürün aldınız"); //3
            //int adet = Convert.ToInt32(Console.ReadLine());
            //double toplam = 0;
            //while (0 < adet)
            //{
            //    Console.WriteLine("ürün fiyatını giriniz");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());

            //    toplam = toplam + fiyat;

            //    adet--;
            //}


            Console.WriteLine("kaç adet ürün aldınız"); //3
            int adet = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            double toplam = 0;
            while (b < adet)
            {
                Console.WriteLine((b+1)+". ürün fiyatını giriniz");
                double fiyat = Convert.ToDouble(Console.ReadLine());

                toplam = toplam + fiyat;

                b++; 
            }

            Console.WriteLine(toplam);

            Console.ReadLine();


        }
    }
}
