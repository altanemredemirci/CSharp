using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ******** VERİ TİPLERİ *********
             
            SAYISAL TİPLER
                (INTEGER - TamSayı): sbyte,byte,... int,uint,long,ulong
                     int sayi=123456;
                     long tc =12345678912;
                  
                (REAL - Ondalıklı) : float,double
                    
                     float maas = 15.000f;
                     double maas2 = 15.000;

                decimal: Bütün sayısal tipleri kapsar.   
                     decimal sayi = 131234542m;


             SÖZEL TİPLER:
                STRING: string:
                    string yazi = "Altan Emre DEMİRCİ";
                CHAR:    
                    char karakter1 = '1';
                    char karakter2 = 'A';
                    char karakter3 = '?';
                
             MANTIKSAL TİP:
                BOOLEAN:bool
                    bool cevap = 5 > 3;
             
             NESNE TİP:
                OBJECT: Bütün veri tipleri kapsar.
                     object cevap = 5;
                     object cevap2 = "5";
                     object cevap3 = true;
             */

            //Console.WriteLine(/*cevap*/+8);



            /*
            CAMEL CASE
              adSoyad
            KEBAB CASE
              ad-soyad
            SNAKE CASE
              ad_soyad
            UPPERCASE
              ADSOYAD
            LOWERCASE
              adsoyad             
             */

            //Console.WriteLine("Altan Emre Demirci");
            //Console.ReadLine();
            //Console.WriteLine("sdasdasda");
            //Console.WriteLine("sdasdasda");
            //Console.WriteLine("sdasdasda");
            //Console.WriteLine("sdasdasda");
            //Console.WriteLine("sdasdasda");

            //STRING KAÇIŞ KARAKTERLERİ
            //Console.WriteLine("Altan\nEmre\n\nDemirci"); // \n alt satıra geçer
            //Console.WriteLine("Altan    Emre\tDemirci"); // \t tab(4) boşluk bırakır.


            //{
            //    int a;
            //    {
            //        int b; //Local değişken parantez kapandığında dışarıda tanınmaz.
            //    }
            //    b = 10;
            //    a = 20;
            //}


            //{
            //    int a;
            //    {
            //        long a;//aynı değişken adı global alanında kullnaıldığı için tekrar kullanılamaz.
            //    }
            //}


            //{
            //    {
            //        long a;
            //    }
            //    {
            //        int a;
            //    }
            //    int a;
            //}


            //const int sayi = 12; //sabit değişken tanımlama. Değer revize EDİLEMEZ.
            //sayi = 13;

            int a, b;
           
            int c;
            c = 20;




            Console.ReadLine();
        }
    }
}
