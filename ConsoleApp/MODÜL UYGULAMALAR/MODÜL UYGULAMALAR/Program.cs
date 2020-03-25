using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODÜL_UYGULAMALAR
{
    class Program
    {
        static void Main(string[] args)
        {
            double not, not1, not2, ort;
            Console.WriteLine("=======================================");
            Console.WriteLine("        ORTALAMA PROGRAMI              ");
            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("BİRİNCİ NOTUNUZU GİRİNİZ  :");
            not = Convert.ToInt32(Console.ReadLine());

            Console.Write("İKİNCİ NOTUNUZU GİRİNİZ   :");
            not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ÜÇÜNCÜ NOTUNUZU GİRİNİZ   :");
            not2 = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            ort = (not + not1 + not2) / 3; 

            Console.WriteLine("BİRİNCİ YAZILINIZ : " + not + "\n İKİNCİ YAZILINIZ : " + not1 + "\n ÜÇÜNCÜ YAZILINIZ : " + not2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("VEEEEE ORTALAMAAAANIZ : " + ort);

            Console.ReadKey();



        }
    }
}
