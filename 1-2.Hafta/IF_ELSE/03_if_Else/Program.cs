using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak yaş değerine göre
            /*  
             0-3 arasında ise bebek
             4-10 arasında çocuk
             11-18 ergen
             19-28 genç
             29-35 orta yaç
             36-45 olgun
             46-55 emekli adayı
             56 ve üstü ise emekliliğin tadını çıkarın
             */

            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //if (yas < 0)
            //{
            //    Console.WriteLine(Math.Abs(yas));

            //}

            #region ZEYNEP ÇAM

            /*
            Console.WriteLine("Yaşı giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas >= 0 && yas <= 3) //0,1,2,3
            {
                Console.WriteLine("bebek");
            }
            else if (yas >= 4 && yas <= 10)
            {
                Console.WriteLine("çocuk");
            }
            else if (yas >= 11 && yas <= 18)
            {
                Console.WriteLine("ergen");
            }
            else if (yas >= 19 && yas <= 28)
            {
                Console.WriteLine("genç");
            }
            else if (yas >= 29 && yas <= 35)
            {
                Console.WriteLine("orta yaş");
            }
            else if (yas >= 36 && yas <= 45)
            {
                Console.WriteLine("olgun");
            }
            else if (yas >= 46 && yas <= 55)
            {
                Console.WriteLine("emekli adayı");
            }
            else if(yas>55 && yas<130)
            {
                Console.WriteLine("emekliliğin tadını çıkarın");
            }
            else
            {
                Console.WriteLine("Yaş girişi hatalı");
            }
            Console.ReadLine();
            */

            #endregion


            #region ZEYNEP TEZCAN
            /*
            Console.WriteLine("yaşınız kaçtır?");
            int yas = Convert.ToInt32(Console.ReadLine());


            if (yas > 0 && yas < 4)
            {
                Console.WriteLine("bebek");
            }
            else if (yas >= 4 && yas < 10)
            {
                Console.WriteLine("çocuk");
            }
            else if (yas > 11 && yas < 18)
            {
                Console.WriteLine("ergen");
            }
            else if (yas > 19 && yas < 28)
            {
                Console.WriteLine("genç");
            }
            else if (yas > 29 && yas < 35)
            {
                Console.WriteLine("orta yaş");
            }
            else if (yas > 36 && yas < 45)
            {
                Console.WriteLine("olgun");
            }
            else if (yas > 46 && yas < 55)
            {
                Console.WriteLine("emekli dayı");
            }
            else if (yas >= 56)
            {
                Console.WriteLine("emekliliğin tadını çıkarın");
            }
            else
            {
                Console.WriteLine("yanlış değer");
            }



*/
            #endregion


            #region HÜSEYİN
            /*
             Console.WriteLine("Yaşınızı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 4)
            {
                Console.WriteLine("bebek");
            }
            else if (sayi > 4 && sayi < 11)
            {
                Console.WriteLine("cocuk");
            }
            else if (sayi > 10 && sayi < 19)
            {
                Console.WriteLine("ergen");
            }
            else if (sayi > 18 && sayi < 29)
            {
                Console.WriteLine("genc");
            }
            else if (sayi > 28 && sayi < 36)
            {
                Console.WriteLine("orta yaş");

            }
            else if (sayi > 35 && sayi < 46)
            {
                Console.WriteLine("olgun");
            }
            else if ( sayi > 45 && sayi <56)
            {
                Console.WriteLine("emekli adayi");
            }
            else
            {
                Console.WriteLine("emekliligin tadini cikar");
            }


            Console.ReadLine();

             
             */
            #endregion

            #region NİSA
            /*
             Console.WriteLine("yasinızı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 4)
            {
                Console.WriteLine("bebek");
            }
            else if (sayi > 4 && sayi < 11)
            {
                Console.WriteLine("cocuk");
            }
            else if (sayi > 10 && sayi < 19)
            {
                Console.WriteLine("ergen");
            }
            else if (sayi > 18 && sayi < 29)
            {
                Console.WriteLine("genc");
            }
else if (sayi > 28 & &sayi < 36)
            {
                Console.WriteLine("orta yas );

            }
            else if (sayi > 35 && sayi < 46)
            {
                Console.WriteLine("olgun");
            }
            else if ( sayi > 45 && sayi <56)
            {
                Console.WriteLine("emekli adayi");
            }
            else
            {
                Console.WriteLine("emekliligin tadini cikar")



            Console.ReadLine();

             */
            #endregion


            Console.WriteLine("Yaş:");
            int yas = Convert.ToInt32(Console.ReadLine());
           
            if(yas<0 || yas > 130)
            {
                Console.WriteLine("Yaş aralığı hatalı");
            }
            else if(yas<4)
            {

            }
            else if(yas<11)



            Console.ReadLine();
        }
    }
}
