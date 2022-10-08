using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *ÖDEV:
             kullanıcıdan alınan cinsiyet bilgisine göre
             ==> ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
                ==> KADIN ise
                 yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
                 ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */

            Console.WriteLine("Cinsiyet:");
            string cins = Console.ReadLine();

            int yas=0;
            double maas=0;

            switch (cins)
            {
                case "erkek":
                    Console.WriteLine("Yaş:");
                    yas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Maaş:");
                    maas = Convert.ToDouble(Console.ReadLine());

                    if (yas > 59)
                    {
                        Console.WriteLine("Emeklilik İkramiyesi:"+(maas*10));
                    }
                    else
                    {
                        Console.WriteLine("Prim gün sayısı:");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim >= 6000)
                        {
                            Console.WriteLine("Emeklilik İkramiyesi:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik hayal çalışmaya devam...");
                        }
                    }


                    break;

                case "kadın":
                    Console.WriteLine("Yaş:");
                    yas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Maaş:");
                    maas = Convert.ToDouble(Console.ReadLine());

                    if (yas > 54)
                    {
                        Console.WriteLine("Emeklilik İkramiyesi:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim gün sayısı:");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim >= 4500)
                        {
                            Console.WriteLine("Emeklilik İkramiyesi:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik hayal çalışmaya devam...");
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Hatalı Cinsiyet Girişi!!!");
                    break;
            }
        }
    }
}
