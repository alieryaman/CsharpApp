using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜÇGENİN_ALANINI_BULAN_PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, h, a;
            Console.Write("ÜÇGENİN TABANINI GİRİNİZ : ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("YÜKSEKLİĞİNİ GİRİNİZ : ");
            h = Convert.ToInt32(Console.ReadLine());
            a = t * h / 2;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("ÜÇGENİN ALANI : " + a);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("İ Y İ  G Ü N L E R  D İ L E R İ Z :)"); 
            Console.ReadKey();


        }
    }
}
