using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, syd, snf, ders, drm = "", nmr;
            int y1 = 0, y2 = 0, szl = 0, ort = 0, knot = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        NOT BULAN PROGRAM      ");
            Console.WriteLine("        by VEYSEL KARTALMIŞ    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("ADINIZI GİRİNİZ     : ");
            ad = Console.ReadLine();
            Console.Write("SOYADINIZI GİRİNİZ  : ");
            syd = Console.ReadLine();
            Console.Write("SINIFINIZI GİRİNİZ  : ");
            snf = Console.ReadLine();
            Console.Write("NUMARANIZI GİRİNİZ  : ");
            nmr = Console.ReadLine();
            Console.Write("DERSİ GİRİNİZ       : ");
            ders = Console.ReadLine();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        NOT BULAN PROGRAM      ");
            Console.WriteLine("        by VEYSEL KARTALMIŞ    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;

            etiket:Console.Write("1. YAZILI NOTUNUZ   :");
            y1 = Convert.ToInt32(Console.ReadLine());
            if ((y1 > 100) || (y1 < 0)) 
            {
                Console.WriteLine("DEĞERİ 100'DEN KÜÇÜK GİRİNİZ");
                goto etiket;
            }
            etiket1:Console.Write("2. YAZILI NOTUNUZ   :");
            y2 = Convert.ToInt32(Console.ReadLine());
            if ((y2 > 100) || (y2 < 0))
            {
                Console.WriteLine("DEĞERİ 0-100 ARASI RAKAMLA GİRİNİZ");
                goto etiket1;
            }
            etiket2:Console.Write("SÖZLÜ NOTUNUZ       :");
            szl = Convert.ToInt32(Console.ReadLine());
            if ((szl > 100) || (szl < 0))
            {
                Console.WriteLine("DEĞERİ 100'DEN KÜÇÜK GİRİNİZ");
                goto etiket2;
            }
            
            
            
            


            ort = (y1 + y2 + szl) / 3;


            if (ort >= 85)
            {
                knot = 5;
                drm = "TEBRİKLER GEÇTİNİZ :)";
            }
            else
            {
                if (ort >= 70)
                {
                    knot = 4;
                    drm = "TEBRİKLER GEÇTİNİZ :)";
                }
                else
                {
                    if (ort >= 60)
                    {
                        knot = 3;
                        drm = "TEBRİKLER GEÇTİNİZ :)";
                    }
                    else
                    {
                        if (ort >= 50)
                        {
                            knot = 2;
                            drm = "TEBRİKLER GEÇTİNİZ :)";
                        }
                        else
                        {
                            if (ort < 50)
                            {
                                knot = 1;
                                drm = "KALDI";
                            }
                        }
                    }



                }







                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("        NOT BULAN PROGRAM      ");
                Console.WriteLine("        by VEYSEL KARTALMIŞ    ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("ADINIZ           : " + ad);
                Console.WriteLine("SOYADINIZ        : " + syd);
                Console.WriteLine("SINIFINIZ        : " + snf);
                Console.WriteLine("NUMARANIZ        : " + nmr);
                Console.WriteLine("DERSİNİZ         : " + ders);
                Console.WriteLine("ORTALAMANIZ      : " + ort);
                Console.WriteLine("KARNE NOTUNUZ    : " + knot);
                Console.WriteLine("DURUMUNUZ        : " + drm);


                Console.ReadKey();












            }
        }
    }
}
