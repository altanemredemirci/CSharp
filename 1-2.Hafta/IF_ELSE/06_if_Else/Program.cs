using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan aylık gelirini isteyin. 
            // Aylık geliri 14000 üstünde ise %12 vergi kesilecek,
            // 14000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            Console.WriteLine("MAAŞ:");
            double gelir = Convert.ToDouble(Console.ReadLine());

            if (gelir > 14000)
            {
                gelir = gelir * 0.88;
            }
            else
            {
                gelir = gelir * 0.91;
            }

            Console.WriteLine("Yeni Gelir:   "  +      gelir);
            Console.ReadLine();

            #region ÖMER   
            /*
             Console.WriteLine("Maaşınız nedir?");
            double maas= Convert.ToDouble(Console.ReadLine());
             
            if (maas < 14000)
        {
                double yenimaas = maas * 0.91;
                Console.WriteLine("Vergi kesinitisi sonrası yeni maaşınız.");
                Console.WriteLine(yenimaas);
        }

        {
            if (maas>14000)
        {
                 double yenimaas2 = maas * 0.88;
                 Console.WriteLine("Vergi kesinitisi sonrası yeni maaşınız.");
                 Console.WriteLine(yenimaas2);

        }
        
            
        }

            Console.ReadLine(); 
             
             */
            #endregion

            #region ZEYNEP TEZCAN
            //Console.WriteLine("AYLIK GELİRİNİZİ GİRİNİZ ");
            //double aylıkGelir = Convert.ToInt32(Console.ReadLine());

            //if (aylıkGelir >= 14000)
            //{
            //    double Vergiyüzde = aylıkGelir * 0.12;
            //    double yeniGelir = aylıkGelir - Vergiyüzde;
            //    Console.WriteLine(yeniGelir);

            //}
            //else if (aylıkGelir < 14000)
            //{
            //    double Vergiyüzde2 = aylıkGelir * 0.9;
            //    double yeniGelir2 = aylıkGelir - Vergiyüzde2;
            //    Console.WriteLine(yeniGelir2);
            //}
            //Console.ReadLine();
            #endregion

            #region HÜSEYİN
            //GELIR:
            //Console.WriteLine("Aylık geirinizi giriniz");
            //double gelir = Convert.ToDouble(Console.ReadLine());

            //if (gelir <= 0)
            //{
            //    Console.WriteLine("hatalı giriş yaptınız,tekrar giriniz");
            //    goto GELIR;
            //}
            //else
            //{

            //    if (gelir >= 14000)
            //    {
            //        Console.WriteLine("net geliriniz:" + (gelir * (0.88)));
            //    }
            //    else
            //    {
            //        Console.WriteLine("net geliriniz:" + (gelir * (91 / 100)));
            //    }




            //}

            //Console.ReadLine();
            #endregion


        }
    }
}
