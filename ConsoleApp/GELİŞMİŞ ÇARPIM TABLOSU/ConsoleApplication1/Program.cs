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
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j <11; j++)
                {
                    Console.WriteLine( i     +    " X "     +        j     +    " = "    + (j*i) ); 
                }
                Console.WriteLine("--------------------------");



            }
            Console.ReadKey();
        }
    }
}
