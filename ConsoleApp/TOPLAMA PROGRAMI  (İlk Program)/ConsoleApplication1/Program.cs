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
            string  n;
            int a, b, t;
            Console.Write("ADINIZI GİRİNİZ       : ");
            n = Console.ReadLine();
            Console.Write("BİR SAYI GİRİNİZ      : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İKİNCİ SAYIYI GİRİNİZ : ");
            b = Convert.ToInt32(Console.ReadLine());
            t = a + b;
            
            Console.WriteLine("MERHABA " + n);
            Console.Write("İKİ SAYININ TOPLAMI:" + t );
            Console.ReadKey();


        }
    }
}
