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
            double a, b, carp, top, cık, bol;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                    BY VEYSEL                       ");
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BİR SAYI GİRİNİZ      : ");
            a = Convert.ToInt64(Console.ReadLine());

            Console.Write("İKİNCİ SAYIYI GİRİNİZ : ");
            b = Convert.ToInt64(Console.ReadLine());

            carp = a * b;
            bol = a / b;
            top = a + b;
            cık = a - b;

            Console.WriteLine("SAYILARIN TOPLAMI    ; ");
            Console.WriteLine( a + "+" + b + "=" + top);

            Console.WriteLine("SAYILARIN FARKI      ; ");
            Console.WriteLine(a + "-" + b + "=" + cık);

            Console.WriteLine("SAYILARIN ÇARPIMI    ; ");
            Console.WriteLine(a + "*" + b + "=" + carp);
           

            Console.WriteLine("SAYILARIN BÖLÜMÜ     ; ");
            Console.WriteLine(a + "/" + b + "=" + bol);

            Console.ReadKey();
            





        }
    }
}
