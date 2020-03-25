using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAÇ_YIL_YAŞADIĞINI_BULAN_PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int DoğumYılı, Yaş, Ay, Gün, Saat;

            Console.WriteLine("=================================================");
            Console.WriteLine("               by VEYSEL KARTALMIŞ               ");
            Console.WriteLine("=================================================");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doğum Yılını Gir: ");
            DoğumYılı = Convert.ToInt32(Console.ReadLine());


            Yaş = 2014 - DoğumYılı;
            Ay = 12 * Yaş;
            Gün = 365 * Yaş;
            Saat = 24 * Gün;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YAŞIN          = " + Yaş);
            Console.WriteLine("YAŞADIĞIN AY   = " + Ay);
            Console.WriteLine("YAŞADIĞIN GÜN  = " + Gün);
            Console.WriteLine("YAŞADIĞIN SAAT = " + Saat);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("BU KADARDIR YAŞIYOSUN ALLAH UZUN ÖMÜR VERSİN :) ");


            Console.ReadKey();

            
        }
    }
}
