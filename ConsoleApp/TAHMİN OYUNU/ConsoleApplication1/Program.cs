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
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("             TAHMİN OYUNU                ");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.ForegroundColor = ConsoleColor.Green;
            int tahmin = 0;
            int[] sayılar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("BİR SAYI GİRİNİZ :");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Random rnd = new Random();
            int a = rnd.Next(1, 5);

            Console.Write(a + ". SAYIYI GİRİNİZ ");
            tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin==sayılar[a-1])
            {
                Console.Write("TEBRİKLER !");
            }
            else
            {
                Console.Write("YANLIŞ TAHMİN !");
            }

            Console.ReadKey();


        }
    }
}
