using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GELİŞMİŞ_ORTALAMA_PROGRAMI
{
    class Program
    {
        static void Main(string[] args)
        {
            kartal:
            string   b = "";
            int s=0, top=0, ort=0, syc=0,v;
            c
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           by VEYSEL KARTALMIŞ             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.White;        
            
            Console.Write("KAÇ SAYI GİRMEK İSTERSİN? : ");
            v = Convert.ToInt32(Console.ReadLine());                       
            veysel:
            Console.Write((syc + 1) + ". SAYIYI GİRİNİZ    : ");
            s = Convert.ToInt32(Console.ReadLine());
            top = top + s;
            syc = syc + 1;

            if (syc < v)
            {
                goto veysel;
            }

            ort = top / v;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SAYILARIN ORTALAMASI " + ort);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ÇIKMAK İÇİN 1 BAŞA DÖNMEK İÇİN 2'Yİ TUŞLA : ");
            b = Console.ReadLine();
            if (b == "1")
            {
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                goto kartal;
            }
            Console.ReadKey();
            











        }
    }
}
