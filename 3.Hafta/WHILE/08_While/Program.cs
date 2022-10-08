using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *********** SAYI TAHMİN OYUNU **********
            /*
             Bilgisayar 1-100 arasında random bir sayıyı aklında tutaacak
            Kullanıcıya 5 hak vererek tahmin etmesini isteyeceğiz.
            Her tahminde kullanıcıyı yönlendireceğiz.
                Tahmininizi küçültünüz
                Tahmininizi büyültünüz.
             Hakkı bittiğinde 10 saniye bekleterek tekrar giriş hakkı veriniz.
             */

            Random r = new Random(); //Instance 

            int rastgele = r.Next(1, 100);

            Console.WriteLine(rastgele);

        //DON:
            int hak = 5;

            
            while (hak>0)
            {
                Console.WriteLine("Tahmininiz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin==rastgele)
                {
                    Console.WriteLine("Tebrikler..");
                    break;
                }
                else if(tahmin>rastgele)
                {
                    Console.WriteLine("Tahmininizi küçültünüz.");
                }
                else
                {
                    Console.WriteLine("Tahmininizi büyültünüz.");
                }

                hak--;

                if (hak == 0)
                {
                    Console.WriteLine("10 saniye sistem kitlendi");
                    Thread.Sleep(3000);
                    hak=5

                }



            }
            //if (hak == 0)
            //{
            //    Console.WriteLine("10 saniye sistem kitlendi");
            //    Thread.Sleep(3000);

            //    goto DON;
            //}



            Console.ReadLine();
        }
    }
}
