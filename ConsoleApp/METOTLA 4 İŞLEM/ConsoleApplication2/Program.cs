using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {       static int  topla(int sayı1,int sayı2)
            { 
                 int toplam;
                 toplam = sayı1+sayı2;
        return toplam;
            }
    static int bolme(int sy1, int sy2)
    {
        int bolme;
        bolme = sy1 / sy2;
        return bolme;
    }
    static int carp(int say1, int say2)
    {
        int carpma;
        carpma = say1 * say2;
        return carpma;
    }
    static int cikma(int sayıı1, int sayıı2)
    {
        int cıkarma;
        cıkarma = sayıı1 - sayıı2;
        return cıkarma;
    }

        static void Main(string[] args)
        {
            int sayı1, sayı2;
            Console.Write("İLK SAYIYI GİRİNİZ : ");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İKİNCİ SAYIYI GİRİNİZ : ");
            sayı2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TOPLAMA ------> 1");
            Console.WriteLine("ÇIKARMA ------> 2");
            Console.WriteLine("ÇARPMA  ------> 3");
            Console.WriteLine("BÖLME   ------> 4");
            Console.Write("SEÇİMİNİZ NEDİR ? : ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine(topla(sayı1, sayı2));
                    break;
                case 2:
                    Console.WriteLine(cikma(sayı1, sayı2));
                    break;
                case 3:
                    Console.WriteLine(carp(sayı1, sayı2));
                    break;
                case 4:
                    Console.WriteLine(bolme(sayı1, sayı2));
                    break;
                    
            }
            Console.ReadKey();



        }
    }
}
