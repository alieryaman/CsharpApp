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
            int sayı;
            string cevap;
            string[] gunler = new string[7];
            gunler[0] = "PAZARTESİ";
            gunler[1] = "SALI";
            gunler[2] = "ÇARŞAMBA";
            gunler[3] = "PERŞEMBE";
            gunler[4] = "CUMA";
            gunler[5] = "CUMARTESİ";
            gunler[6] = "PAZAR";

            Random rnd = new Random();
            sayı = rnd.Next(1,7);

            Console.Write("HAFTANIN " +sayı + ". GÜN HANGİ GÜNDÜR ?: ");
            cevap = Console.ReadLine();
            cevap = cevap.ToUpper();
            if (cevap == gunler[sayı-1])
            {
                Console.Write("CEVABINIZ DOĞRU !");
            }
            else
            {
                Console.Write("CEVABINIZ YANLIŞ !");
            }
            Console.ReadKey();




        }
    }
}
