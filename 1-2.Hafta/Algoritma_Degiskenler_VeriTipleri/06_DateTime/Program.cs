using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih);
            Console.WriteLine(tarih);

            DateTime zaman = new DateTime(2022, 09, 07);
            Console.WriteLine(zaman);

            Console.WriteLine(tarih.Day-zaman.Day);

            

            Console.ReadLine();
        }
    }
}
