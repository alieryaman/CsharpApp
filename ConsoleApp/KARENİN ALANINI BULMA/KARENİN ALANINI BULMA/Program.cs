using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARENİN_ALANINI_BULMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, snc;
            string ad;
            Console.Write("ADINIZI GİRİNİZ : ");
            ad = Console.ReadLine();
            Console.Write("KARENİN BİR KENAR UZUNLUĞUNU GİRİNİZ :");
            a = Convert.ToInt32(Console.ReadLine());
            snc = a * a;
            Console.WriteLine("MERHABA " + ad);
            Console.Write("KARENİN ALANI : " + snc );
            Console.ReadKey();
        }
    }
}
