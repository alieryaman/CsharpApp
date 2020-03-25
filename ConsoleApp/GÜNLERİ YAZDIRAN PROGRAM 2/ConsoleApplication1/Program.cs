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
            string[] gunler = new string[7];
            gunler[0]="PAZARTESİ";
            gunler[1]="SALI";
            gunler[2]="ÇARŞAMBA";
            gunler[3]="PERŞEMBE";
            gunler[4]="CUMA";
            gunler[5]="CUMARTESİ";
            gunler[6] = "PAZAR";
            foreach (string gun in gunler)
            {
                Console.WriteLine(gun);
            }
            Console.ReadKey();
        }
    }
}
