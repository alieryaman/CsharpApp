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
        veysel:
            int a, kalan, bol;
            string evet;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("              BY VEYSEL                   ");
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BİR SAYI GİRİNİZ  : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("BU SAYIYI KAÇA BÖLMEK İSTERSİNİZ  : ");
            bol = Convert.ToInt32(Console.ReadLine());

            kalan = a % bol;

            Console.WriteLine("{0} SAYINISININ {1} SAYISINA BÖLÜMÜNDEN KALAN : {2} ", a, bol, kalan);

            Console.Write("TEKRAR BAŞA DÖNMEK İSTER MİSİNİZ ? (DÖNMEK İÇİN 1 / BİTİR 2)  : ");
            evet = Console.ReadLine();
            if (evet == "1")
            {
                Console.Clear();
                goto veysel;
            }
            else
            {
                if (evet == "2")
                {
                    Console.ReadKey();
                }
                
            }

        }
    }
}
