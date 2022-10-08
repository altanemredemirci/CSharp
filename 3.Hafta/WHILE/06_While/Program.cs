using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 ürün fiyatını alınız ve en düşük fiyata %25 indirim uygulayınız.

            int i = 0;
            Console.WriteLine("Ürün fiyatı:"); //100
            int enDusuk = Convert.ToInt32(Console.ReadLine());

            while (i < 2)
            {
                Console.WriteLine("Ürün fiyatı:"); //50
                int fiyat = Convert.ToInt32(Console.ReadLine());

                if (enDusuk > fiyat)
                    enDusuk = fiyat;               

            }
        }
    }
}
