using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Tür_Dönüştürme
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* VERİ TİPİ DÖNÜŞÜTÜRME
              1-Bilinçsiz Tür Dönüşümü
              2-Bilinçli Tür Dönüşümü
              3-Boxing Tür Dönüşümü
              4-Unboxing Tür Dönüşümü
             
             */
            //1 - Bilinçsiz Tür Dönüşümü
            //int sayi = 1;
            //decimal sayi2 = sayi; //Büyük veri tipine küçük veri tipi atanması.


            //decimal s3 = 1;
            //int s4 = s3; // HATA


            //char a = '1';
            //int b = a;
            //Console.WriteLine(b);


            //2 - Bilinçli Tür Dönüşümü
            //decimal sayi = 124239842379842379842784932m;
            //int sayi2 = (int)sayi; //Boxing

            //Console.WriteLine(sayi2);

            //Console.WriteLine("Bakiyeniz:");
            //string bakiye = Console.ReadLine();
            //int miktar = Convert.ToInt32(bakiye);


            //Console.WriteLine("Bakiyeniz:"); //5000
            //double miktar = Convert.ToDouble(Console.ReadLine());
            //long miktar = long.Parse(Console.ReadLine());

            //Console.WriteLine(miktar - 1000);


            //ToString()
            int sayi = 12;
            string sayi2 = sayi.ToString();

            // sayi = sayi.ToString(); //HATA


            Console.ReadLine();
        }
    }
}
