using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan iki adet sayı isteyin, farkını negatif değer olmayacak şekilde alınız

            #region ZEYNEP TEZCAN
            /*
             Console.WriteLine("Birinci sayıyı girin");
            double birinciSayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin");
            double ikinciSayi = Convert.ToDouble(Console.ReadLine());


            //2.Yöntem
            Console.WriteLine("FARK={0}", Math.Abs(birinciSayi - ikinciSayi));
            Console.WriteLine("Birinci sayıyı girin");
            double birinciSayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin");
            double ikinciSayi = Convert.ToDouble(Console.ReadLine());

            if (birinciSayi >= ikinciSayi)
                Console.WriteLine("FARK", birinciSayi - ikinciSayi);
            else
                Console.WriteLine("FARK", ikinciSayi - birinciSayi);

            Console.ReadLine();

             */
            #endregion

            #region HÜSEYİN
            Console.WriteLine("Birinci sayıyı giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double fark = sayi1 - sayi2;

            Console.WriteLine(Math.Abs(fark));

            Console.ReadLine();
            #endregion
        }
    }
}
