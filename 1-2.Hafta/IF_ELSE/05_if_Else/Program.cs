using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan vize ve final notlarını alınız. Ortalama hesaplayınız (%40 vize %60 final)
             0 - 24  => FF
             25 - 44 => DD
             45 - 54 => CC
             55 - 69 => BB
             70 - 84 => BA
             85 - 100=> AA
             
            */


            #region HÜSEYİN
            /*
            Console.WriteLine("Vize notunu giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());



            double ortalama = (vize * 40 / 100) + (final * 60 / 100);

            if (ortalama <= 24)
            {
                Console.WriteLine("FF");
            }
            else if (ortalama <= 44)
            {
                Console.WriteLine("DD");

            }
            else if (ortalama <= 54)
            {
                Console.WriteLine("CC");
            }
            else if (ortalama <= 69)
            {
                Console.WriteLine("BB");
            }
            else if (ortalama <= 84)
            {
                Console.WriteLine("BA");
            }
            else
            {
                Console.WriteLine("AA");
            }


            Console.ReadLine();*/
            #endregion

            #region ZEYNEP ÇAM
            /*
             Console.WriteLine("Vize notunu giriniz:");
            int vize=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz: ");
            int final=Convert.ToInt32(Console.ReadLine());

            double ortalama = vize * 0.4 + final * 0.6;
            if (ortalama >= 0 && ortalama <= 24)
            {
                Console.WriteLine("FF aldınız.");
            }
            else if (ortalama >= 25 && ortalama <= 44)
            {
                Console.WriteLine("DD aldınız.");
            }

            else if (ortalama >= 45 && ortalama <= 54)
            {
                {
                    Console.WriteLine("CC aldınız.");
                }
            }
            else if (ortalama >= 55 && ortalama <= 69)
            {
                {
                    Console.WriteLine("BB aldınız.");
                }
            }
            else if (ortalama >= 70 && ortalama <= 84)
            {
                {
                    Console.WriteLine("BA aldınız.");
                }
            }
            else if (ortalama >= 85 && ortalama <= 100)
            {
                {
                    Console.WriteLine("AA aldınız.");
                }
            }
            else
            {
                Console.WriteLine("hatalı not girdiniz");
            }

            Console.ReadLine();
             */
            #endregion

            #region ÖMER FARUK
            /*
             Console.WriteLine("Vize notunuz");
            int vize=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuz");
            int final=Convert.ToInt32(Console.ReadLine());
            double ortalama =( (vize * 0.4) + (final * 0.6));

            if (ortalama >= 0 && ortalama <= 24)
            {
                Console.WriteLine("Notunuz FF.");
            }
            else if (ortalama >= 25 && ortalama <= 44) 
            {
                Console.WriteLine("Notunuz DD.");
            }
            else if (ortalama >= 45 && ortalama <= 54)
            {
                Console.WriteLine("Notunuz CC.");
            }
            else if (ortalama >= 55 && ortalama <= 69)
            {
                Console.WriteLine("Notunuz BB.");
            }
            else if (ortalama >= 70 && ortalama <= 84)
            {
                Console.WriteLine("Notunuz BA.");
            }
            else if (ortalama >= 85 && ortalama <= 100)
            {
                Console.WriteLine("Notunuz AA.");
            }
            else
            {
                Console.WriteLine("Not değer aralığında değil");
            }

            Console.ReadLine();
             
             */
            #endregion

            #region ZEYNEP TEZCAN
            /*
            Console.WriteLine("vize notunu giriniz ");
            int vize = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("finalnotunu giriniz ");
            int final = Convert.ToInt32(Console.ReadLine());
            
            double Not = ((vize*0.4) + (final * 0.6));

            if (Not>=0 && Not <= 24)
            {
                Console.WriteLine("FF");
            }
            else if (25 <= Not && Not <= 44)
            {
                Console.WriteLine("DD.");
            }
            else if (45 <= Not && Not <= 54)
            {
                Console.WriteLine("CC");
            }
            else if (55 <= Not && Not <= 69)
            {
                Console.WriteLine("BB");
            }
            else if (70 <= Not && Not <= 84)
            {
                Console.WriteLine("BA");
            }
            else if (85 <= Not && Not <= 100)
            {
                Console.WriteLine("AA");
            }
            else
            {
                Console.WriteLine("GEÇERSİZ DEĞER");
            }
            Console.ReadLine();
        }

             */
            #endregion

            VIZE:
            Console.WriteLine("Vize:");
            double vize = Convert.ToDouble(Console.ReadLine());

            if(vize>=0 && vize < 101)
            {
                FINAL:
                Console.WriteLine("Final:");
                double final = Convert.ToDouble(Console.ReadLine());

                if(final>=0 && final < 101)
                {
                    double ortalama = vize * 0.4 + final * 0.6;

                    if(ortalama<25)
                        Console.WriteLine("FF");
                    else if(ortalama<45)
                        Console.WriteLine("DD");
                    else if (ortalama < 55)
                    {
                        Console.WriteLine("CC");
                    }
                    else if(ortalama<70)
                        Console.WriteLine("BB");
                    else if(ortalama<85)
                        Console.WriteLine("BA");
                    else
                        Console.WriteLine("AA");
                }
                else
                {
                    Console.WriteLine("Final not aralığı hatalı!!!");
                    goto FINAL;
                }
            }

            else
            {
                Console.WriteLine("Vize not aralığı hatalı!!!");
                goto VIZE;
            }

            Console.ReadLine();

        }
    }
}
