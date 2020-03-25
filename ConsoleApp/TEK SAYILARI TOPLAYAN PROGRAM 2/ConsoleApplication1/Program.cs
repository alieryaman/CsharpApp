using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekcalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, tplm=0,mod=0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("BİR SAYI GİRİNİZ :");
                a = Convert.ToInt32(Console.ReadLine());
                mod = a % 2;
                if (mod==1)
                {
                    tplm = tplm + a;
                }
                Console.Write("TEK SAYILARIN TOPLAMI :"+tplm);
                
            }
            Console.ReadKey();

        }
    }
}
