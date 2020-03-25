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
            int a;
            Console.Write("HAFTANIN KAÇINCI GÜNÜNDESİN? : ");
            a = Convert.ToInt16(Console.ReadLine());

            switch (a)
            {
                case 1 :
                    Console.WriteLine("BU GÜN PAZARTESİ ");
                    break;

                case 2:
                    Console.WriteLine("BU GÜN SALI ");
                    break;

                case 3:
                    Console.WriteLine("BU GÜN ÇARŞAMBA ");
                    break;

                case 4:
                    Console.WriteLine("BU GÜN PERŞEMBE ");
                    break;

                case 5:
                    Console.WriteLine("BU GÜN CUMA ");
                    break;

                case 6:
                    Console.WriteLine("BU GÜN CUMARTESİ ");
                    break;

                case 7:
                    Console.WriteLine("BU GÜN PAZAR ");
                    break;

                    

                    
            }
            Console.ReadKey();





        }
    }
}
