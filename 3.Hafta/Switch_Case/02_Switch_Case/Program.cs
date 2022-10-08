using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Örnek: Klavyeden Beşlik sistemde Ders Notu girilecek girilen nota göre Zayıf, Geçer, Orta, İyi, Pekiyi olarak ekrana yazdıran programı switch-case ile yapınız.

            #region ZEYNEP ÇAM
            //Console.WriteLine("not giriniz.");

            //int not = Convert.ToInt32(Console.ReadLine());

            //switch (not)
            //{
            //    case 1:
            //        Console.WriteLine("zayıf");
            //        break;
            //    case 2:
            //        Console.WriteLine("geçer");
            //        break;
            //    case 3:
            //        Console.WriteLine("orta");
            //        break;
            //    case 4:
            //        Console.WriteLine("iyi");
            //        break;
            //    case 5:
            //        Console.WriteLine("pek iyi");
            //        break;
            //    default:
            //        Console.WriteLine("hatalı değer girdiniz");
            //        break;

            //}
            //Console.ReadLine();

            #endregion


            #region ZEYNEP TEZCAN

            
            aa:
            Console.WriteLine("1-5 arasında bir değer giriniz");
            int Sayi = Convert.ToInt32(Console.ReadLine());

            switch (Sayi)
            {

                case 1: Console.WriteLine("Zayıf {0}", Sayi = 1); break;
                case 2: Console.WriteLine("Geçer {0}", Sayi = 2); break;
                case 3: Console.WriteLine("Orta {0}", Sayi = 3); break;
                case 4: Console.WriteLine("iyi {0}", Sayi = 4); break;
                case 5: Console.WriteLine("Pekiyi {0}", Sayi = 5); break;

                default: Console.WriteLine("Hata Böyle bir sayı yok"); break;
            }
            goto aa;


            
            #endregion
        }
    }
}
