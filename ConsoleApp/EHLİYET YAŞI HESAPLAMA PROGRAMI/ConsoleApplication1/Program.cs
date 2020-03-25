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
            int dt, yas;
            Console.Write("DOĞDUĞUNUZ YILI GİRİNİZ: ");
            dt = Convert.ToInt32(Console.ReadLine());
            yas = 2014 - dt;
            if (yas>18)
            {
                
                Console.Write("YAŞIN {0} EHLİYET ALABİLİRSİN ",yas);
            }
            else
            {
                Console.Write("YAŞIN {0} EHLİYET ALAMAZSIN ",yas);
            }
            Console.ReadKey();

        }
    }
}
