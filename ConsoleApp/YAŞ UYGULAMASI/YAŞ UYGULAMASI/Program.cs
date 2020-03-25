using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAŞ_UYGULAMASI
{
    class Program
    {
        static void Main(string[] args)
        {
            // VEYSEL KARTALMIŞ
            string a, b;
            int x, y;
            Console.Write("ADINIZI GİRİNİZ    : ");
            a = Console.ReadLine();
            Console.Write("SOYADINIZI GİRİNİZ : ");
            b = Console.ReadLine();
            Console.Write("DOĞUM TARİHİNİZ    : ");
            x = Convert.ToInt32(Console.ReadLine());
            // BİLGİLER : 

            Console.WriteLine("ADINIZ    : " + a);
            Console.WriteLine("SOYADINIZ : " + b);
            y = 2014 - x;
            Console.WriteLine("YAŞINIZ   : " + y);
            Console.ReadKey();
        }
    }
}
