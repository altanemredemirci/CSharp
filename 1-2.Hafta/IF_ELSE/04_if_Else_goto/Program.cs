using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_if_Else_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DON:
            Console.WriteLine("Yaş:");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas < 0 || yas>120)
            {
                Console.WriteLine("yaş bilgisi hatalı");
                goto DON;
            }
            else
            {
                Console.WriteLine("Doğru yaş girişi");
            }

            Console.ReadLine();
        }
    }
}
