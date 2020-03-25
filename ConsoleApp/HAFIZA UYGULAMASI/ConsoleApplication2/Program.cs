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
            int[] sayılar;
            sayılar = new int[5];
            
            Console.ForegroundColor = ConsoleColor.Red;
            Random rmd = new Random();
            for (int i = 0; i < 5; i++)
            {
                sayılar[i] = rmd.Next(1,30);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayılar[i]);
                Console.Write("", Console.ReadKey());
                Console.Clear();

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ÜÇÜNCÜ SAYI KAÇTIR ?");
            int a = Convert.ToInt32(Console.ReadLine());
            if (sayılar[2] == a) Console.WriteLine("Doğru");
            else Console.WriteLine("Yanlış");
            Console.ReadKey();


        }
    }
}
