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
            veysel:
            int sayı;
            Console.Write("1-7 ARASI BİR SAYI GİRİNİZ : ");
            sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı>7 && sayı<0)
            {
                Console.Write("1-7 ARASI BİR SAYI GİRİNİZ : ");
                goto veysel;
            }

            switch (sayı)
            {
                case 1: Console.WriteLine("1. GÜN PAZARTESİ"); break;
                case 2: Console.WriteLine("2.GÜN SALI "); break;
                case 3: Console.WriteLine("3. GÜN ÇARŞAMBA "); break;
                case 4: Console.WriteLine("4. GÜN PERŞEMBE "); break;
                case 5: Console.WriteLine("5. GÜN CUMA "); break;
                case 6: Console.WriteLine("6. CUMARTESİ "); break;
                case 7: Console.WriteLine("7. GÜN PAZAR "); break;

            }
            Console.ReadKey();
        }
    }
}
