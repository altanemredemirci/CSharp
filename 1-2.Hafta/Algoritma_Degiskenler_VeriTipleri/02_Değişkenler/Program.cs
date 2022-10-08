using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Bir satır boyunca yazılacak data verilir.");
            //Console.WriteLine("Bir satır boyunca yazılacak data verilir.");

            //Console.Write("Yazıyı yazar ve bulunduğu noktada bekler.");
            //Console.Write("Write komutundan dolayı alt satıra geçmeden devam ettik");

            /*
             DEĞİŞKENLER
            programlama içinde veri tutmak için kullanılan etiketlendirme işlemidir.
            Veri tutma: Dışarıdan kullanıcıdan alınan, Yazılımcı tarafından tanımlanan veya işlem sonucu ortaya çıkan veri(data).


            DEĞİŞKEN TANIMLAMA
            veritipi değişkendı = değer;
             
            DEĞİŞKEN İSİMLENDİRME KURALLARI(case sensitive)
            yanlışlar: 5sayi, ?sayi, sayi!, ad soyad,ad-soyad
            doğrular: sayi5, _sayi, sayi_, ad_soyad, adsoyad
            *** Alt tire '_' bütün yazılım dillerinde geçerli tek özel karakterdir.
            
            
            **** Yazılım dillerinde küçük BÜYÜK harf duyarlılığı vardır.
            *
            * Değişken isimleri öznel yapıya sahiptir, bir isim bir defa tanımlanabilir.
             */

            
            string ad = "Altan"; //Değişken Tanımlama
            string ad2 = "Emre";
            string yas = "32";

            int yas2 = 32;
            int yas3 = 23;


            int age = 15;
            age = 25; // Değişken data Update



            //Console.WriteLine(ad+yas); // Metinsel datalar için '+' Concat(birleştirme) yapar.
            //Console.WriteLine(yas+yas2); // Farklı datalar için '+' Concat(birleştirme yapar.)
            //Console.WriteLine(yas2+yas3); // Sayısal datalar için '+' Toplama yapar.

            Console.ReadLine();
        }
    }
}
