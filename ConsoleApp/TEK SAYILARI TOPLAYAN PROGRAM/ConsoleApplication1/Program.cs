using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cvp1, cvp2, cvp3, cvp4, cvp5, kln1, kln2, kln3, kln4, kln5, tplm;
            Console.BackgroundColor = ConsoleColor.Yellow;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("                 copyright©  by VEYSEL                          ");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Console.Write("BİR SAYI GİRİNİZ  : ");
            cvp1 = Convert.ToInt16(Console.ReadLine());
            Console.ReadKey();            

            Console.Write("BİR SAYI GİRİNİZ  : ");
            cvp2 = Convert.ToInt16(Console.ReadLine());
            Console.ReadKey();

            Console.Write("BİR SAYI GİRİNİZ  : ");
            cvp3 = Convert.ToInt16(Console.ReadLine());
            Console.ReadKey();

            Console.Write("BİR SAYI GİRİNİZ  : ");
            cvp4 = Convert.ToInt16(Console.ReadLine());
            Console.ReadKey();

            Console.Write("BİR SAYI GİRİNİZ  : ");
            cvp5 = Convert.ToInt16(Console.ReadLine());
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();

            kln1 = cvp1 % 2;
            kln2 = cvp2 % 2;
            kln3 = cvp3 % 2;
            kln4 = cvp4 % 2;
            kln5 = cvp5 % 2;

            if (kln1 == 0)
            {
                cvp1 = 0;
            }

            if (kln2 == 0)
            {
                cvp2 = 0;
            }

            if (kln3 == 0)
            {
                cvp3 = 0;
            }
            if (kln4 == 0)
            {
                cvp4 = 0;
            }
            if (kln5 == 0)
            {
                cvp5 = 0;
            }

            tplm = cvp1 + cvp2 + cvp3 + cvp4 + cvp5;
             
            Console.Write(" {0} GİRDİĞİNİZ TEK SAYILARIN TOPLAMIDIR ", tplm);
            Console.ReadKey();








        }
    }
}
