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
            Console.Write("SAYIYI YAZINIZ : ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int fakt = 1;
            for (int i = sayı; i >=1; i--)
            {
                fakt = fakt * i;
            }
            Console.WriteLine("SAYININ FAKTORİYELİ : " + fakt);
            Console.ReadKey();
        }
    }
}
