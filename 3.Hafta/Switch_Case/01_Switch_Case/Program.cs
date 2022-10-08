using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            * SWITCH-CASE: IF yapısıyla aynı mantıkta çalışır
            * Switch case yapısı, çok durumlu dallanma ifadelerinde if-else blokları yerine tercihen kullanılırlar. Switch-case ile yapılabilecek tüm işlemler if-else merdiveni ile de yapılabilmektedir.
            * 
            *  1) switch içine değişken yazılır.

               2) case ifadelerinde ise değişkenin eşitliğine göre işlem yapılmasını sağlar. case ifadelerinde sayısal normal yazılır, string " "(çift tırnak) içinde, char ' '(tek tırnak) içinde

               3) Her case’den sonra break yazmak zorunludur.case bölümünün bitiğini belirtir.

                4) default ifadesi ise değerin case şartlarından hiçbirine uymadığında yapılmasını sağlar.


           if(değer==eşitlik1)
           {
                İşlemler
           }
           else if(değer==eşitlik2)
           {
               İşlemler
           }
           else if(değer==eşitlik3)
           {
                İşlemler
           }
           else
           {
                İşlemler
           }


            //BREAK: okunduğu satırdan itibaren devamlı yapıyı(switch, loops(while,for,dowhile,foreach)) yapıyı bitirir.

            */

            //string cinsiyet = "erkek";
            //if (cinsiyet=="erkek")
            //{
            //    Console.WriteLine("Cinsiyet erkek");
            //}
            //else if (cinsiyet == "kadın")
            //{
            //    Console.WriteLine("Cinsiyet erkek");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı cinsiyet girişi!!!");
            //}




            string cinsiyet = "erkek";

            switch (cinsiyet)
            {
                case "erkek":
                    Console.WriteLine("Cinsiyet erkek");
                    break;

                case "kadın":
                    Console.WriteLine("Cinsiyet erkek");
                    break;
                
                default:
                    Console.WriteLine("hatalı cinsiyet girişi!!!");
                    break;
            }

        }
    }
}
