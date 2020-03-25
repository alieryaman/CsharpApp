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
            string ad;
            int a, b, c;
            Console.Write("ADINIZI GİRİNİZ : ");
            ad = Console.ReadLine();
            Console.Write("KISA KENARI GİRİNİZ : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("UZUN KENARI GİRİNİZ : ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a+b+a+b;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("MERHABA " + ad );
            Console.WriteLine("DİKDÖRTGENİN ÇEVRESİ " + c );
            Console.ReadKey();

        }
    }
}
