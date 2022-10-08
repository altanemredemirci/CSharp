using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan  başlangıç ve bitiş değerleri arasında sayıları yine kullanıcıdan alınan artış miktarına göre ekrana yazdırınız.
            //Mesela 10 ile 200 arasındaki sayıları 11 arttırarak ekrana yazdırınız 


            #region ZEYNEP TEZCAN - ÇAM

            Console.WriteLine("birinci sayı gir");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayı gir");
            int bitir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hangi arayla artsın?");
            int artis = Convert.ToInt32(Console.ReadLine());
            if (basla > bitir)
            {
                for (int i = bitir; i < basla; i += artis)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                for (int i = basla; i < bitir; i += artis)
                {
                    Console.WriteLine(i);
                }
            }
           
            Console.ReadLine();

            #endregion


        }
    }
}
