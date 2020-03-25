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
            string yildiz = "";
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 0; k <= 5 - i; k++)
                yildiz = yildiz + "*";
                Console.WriteLine(yildiz);
                yildiz = "";
            }
            Console.ReadKey();

        }
    }
}
