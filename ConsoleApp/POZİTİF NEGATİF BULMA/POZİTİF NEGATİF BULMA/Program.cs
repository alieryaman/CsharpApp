using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POZİTİF_NEGATİF_BULMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("BİR SAYI GİRİNİZ :   ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
                Console.WriteLine("SAYINIZ NEGATİFTİR");
            else
            {
                Console.WriteLine("SAYINIZ POZİTİFTİR"); 
            }
            if (x == 0)
                Console.WriteLine("SAYINIZ SIFIRA EŞİTTİR");
                    Console.ReadKey();

        }
    }
}
