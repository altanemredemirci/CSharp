using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya 3 giriş hakkı vererek kullanıcı adı ve şifresini girerek giriş yapmasını isteyelim

            string username = "admin";
            string password = "123";


            int hak = 1;
            while (hak < 4) // hak=1,2,3
            {
                Console.WriteLine("Kullanıcı adı:");
                string kadi = Console.ReadLine();
                Console.WriteLine("Şifreniz:");
                string sifre = Console.ReadLine();

                if (username == kadi && password == sifre)
                {
                    Console.WriteLine("Giriş Başarılı");
                    break; // BREAK: Loop bitirir. İçe İçe döngü olması durumunda içinde bulunduğu döngüyü bitirir.
                }
                else if(hak<3)
                {
                    Console.WriteLine("Giriş bilgileri hatalı!!");
                }
                hak++;

            }

            if (hak == 4)
            {
                Console.WriteLine("Hakkınız Bitti.");
            }
            Console.ReadLine();
        }
    }
}
