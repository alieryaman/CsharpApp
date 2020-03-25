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
           Console.Write("ADINIZI GİRİNİZ :");
           string ad = Console.ReadLine();
           for (int i = 0; i <= 10; i++)
           {
               Console.WriteLine(ad);
           }
           Console.ReadKey();
        }
    }
}
