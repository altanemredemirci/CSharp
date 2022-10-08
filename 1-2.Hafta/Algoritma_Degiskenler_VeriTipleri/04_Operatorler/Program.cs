using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ARİTMATİK OPERATÖRLER(+,-,*,/,%)
               float i = 2f / 5 / 2;
             
             * BİRER ARTTIRMA BİRER AZALTMA(++ , --)
            int sayi = 5;
            
            //sayi = sayi + 5;
            
            //sayi += 5; 
            
            //sayi++;
            sayi--;
             
            * KARŞILAŞTIRMA OPERATÖRLERİ
             int sayi=4
             int sayi2=7

            ==  eşit mi?
            !=  eşit değil mi?  
            >
            <
            >=
            <=
            */
            //int sayi = 4;
            //int sayi2 = 7;
            //Console.WriteLine(sayi==sayi2);
            //Console.WriteLine(sayi<=sayi2);
            //Console.WriteLine(sayi>=sayi2);
            //Console.WriteLine(sayi!=sayi2);
            /*

            * MANTIKSAL OPERATÖRLER (VE;VEYA;DEĞİL)
             
                VE(&&): Birden fazla koşul kontrolü için kullanılır. True sonucu vermesi her koşulun sağlanması gerekir.
             
                    1.koşul   &&  2.koşul = SONUC
                        0           0         0
                        0           1         0
                        1           0         0
                        1           1         1
          

                    string username = "altanemre";
                    string password = "123";

                    Console.WriteLine("Kullanıcı Adınız:");
                    string name = Console.ReadLine(); //her zaman string data döndürür.

                    Console.WriteLine("Şifreniz:");
                    string sfr = Console.ReadLine();


                    bool girisDurumu = username == name &&  password == sfr;
            Console.WriteLine(girisDurumu);
             
            VEYA(||): Birden fazla koşul kontrolü için kullanılır. Koşullardan herhangi biri  sağlanması durumunda True döndürür.

                    1.koşul   &&  2.koşul = SONUC
                        0           0         0
                        0           1         1
                        1           0         1
                        1           1         1
                
                    
                    //string username = "altanemre";
                    //string email = "altanemre@gmail.com";
                    //string password = "123";

                    //Console.WriteLine("Kullanıcı adı / Email:");
                    //string name = Console.ReadLine(); //her zaman string data döndürür.

                    //Console.WriteLine("Şifreniz:");
                    //string sfr = Console.ReadLine();


                    //bool girisDurumu = (username == name || email==name)    &&  password == sfr;
                    //Console.WriteLine(girisDurumu);


            DEĞİL(!): True => False       False=> True

            //bool deger = true;
            //Console.WriteLine(!deger);

            
             * KIYAS OPERATÖRLER (? :) 
            
          

            string username = "altanemre";

           //                   Karşılaştırma  ?(True) " " :(False) " "
            string cevap = username == "altanemre" ? "Kullanıcı adı Doğru" : "Kullanıcı adı Yanlış";
            bool cevap2 = 12 == 12 ? true : false;
            int cevap3 = "a" == "b" ? 1 : 0;

            Console.WriteLine(cevap+"\n"+cevap2+"\n"+cevap3);

            
             * ERİŞİM OPERATÖRÜ(.)
             Tanımlı class içerisindeki property lere erişim sağlar.
             
            TYPEOF

             
             */

            Type a = typeof(int);
            Console.WriteLine(a);

            Console.WriteLine("Size of int is "+sizeof(int));
            Console.WriteLine("Size of short is {0} {1}",sizeof(short),12);
            Console.WriteLine($"Size of long is {sizeof(long)}");

            Console.ReadLine();
        }
    }
}
