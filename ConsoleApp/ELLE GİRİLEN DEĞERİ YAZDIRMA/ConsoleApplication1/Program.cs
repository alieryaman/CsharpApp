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
            int ilk=0, orta=0, son=0;
            Console.Write("İLK DEĞERİNİZ :");
            ilk = Convert.ToInt32(Console.ReadLine());
            Console.Write("SON DEĞERİNİZ :");
            orta = Convert.ToInt32(Console.ReadLine());
            Console.Write("ARTTILICAK MİKTAR :");
            son = Convert.ToInt32(Console.ReadLine());

            for (int i = ilk; i < orta; i=i+son)
            {
                Console.WriteLine(ilk);
            }
            Console.ReadKey();

        }


    }
}
