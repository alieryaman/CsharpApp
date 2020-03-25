using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tahmin;
            string[] plaka = new string[10];
            plaka[0] = "ADANA";
            plaka[1] = "ADIYAMAN";
            plaka[2] = "AFYON";
            plaka[3] = "AĞRI";
            plaka[4] = "AMASYA";
            plaka[5] = "ANKARA";
            plaka[6] = "ANTALYA";
            plaka[7] = "ARTVİN";
            plaka[8] = "AYDIN";
            plaka[9] = "BALIKESİR";

            Random rnd = new Random();
            int a = rnd.Next(1,10);

            Console.Write(a + ". ŞEHİRİN PLAKASINI GİRİNİZ: ");
            tahmin = Console.ReadLine();

            if (tahmin==plaka[a-1])
            {
                Console.Write("TEBRİKLER DOĞRU");
            }

            else
            {
                Console.Write("MAALESEF YANLIŞ");
            }

            Console.ReadKey();
        }
    }
}
