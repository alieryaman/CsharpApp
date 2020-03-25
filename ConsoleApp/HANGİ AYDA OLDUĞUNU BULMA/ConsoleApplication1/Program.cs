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
            int ay;
            Console.Write("KAÇINCI AYDASIN ? : ");
            ay = Convert.ToInt16(Console.ReadLine());

            switch (ay)
            {
                case 1:
                    Console.WriteLine("OCAK AYINDASIN");
                    break;
                case 2:
                    Console.WriteLine("ŞUBAT AYINDASIN");
                    break;
                case 3:
                    Console.WriteLine("MART AYINDASIN");
                    break;
                case 4:
                    Console.WriteLine("NİSAN AYINDASIN");
                    break;
                case 5:
                    Console.WriteLine("MAYIS AYINDASIN");
                    break;
                case 6:
                    Console.WriteLine("HAZİRAN AYINDASIN");
                    break;
                case 7:
                    Console.WriteLine("TEMMUZ AYINDASIN");
                    break;
                case 8:
                    Console.WriteLine("AĞUSTOS AYINDASIN");
                    break;
                case 9:
                    Console.WriteLine("EYLÜL AYINDASIN");
                    break;
                case 10:
                    Console.WriteLine("EKİM AYINDASIN");
                    break;
                case 11:
                    Console.WriteLine("KASIM AYINDASIN");
                    break;
                case 12:
                    Console.WriteLine("ARALIK AYINDASIN");
                    break;

                default: Console.WriteLine("LÜTFEN 1-12 ARASI BİR SAYI GİRİNİZ !");
                goto veysel;


            }



            Console.ReadKey();







        }
    }
}
