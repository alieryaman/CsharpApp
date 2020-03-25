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
            double cp;
            Console.Write("TELEFON NUMARANIZI GİRİNİZ  :  ");
            cp = Convert.ToInt64(Console.ReadLine());

            Console.Write("TELEFON MUNARANIZ : {0: (###) ### ## ##} ", cp);
            Console.ReadKey();








        }
    }
}
