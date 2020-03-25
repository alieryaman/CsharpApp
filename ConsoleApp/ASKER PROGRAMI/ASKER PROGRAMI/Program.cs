using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASKER_PROGRAMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //int yıl = 2015;
            string ad, syd,  cnsyt;
            int dtr, yas;
            Console.Write("ADINIZI GİRİNİZ    :  ");
            ad = Console.ReadLine();
            Console.Write("SOYADINIZI GİRİNİZ :  ");
            syd = Console.ReadLine();
            Console.Write("CİNSİYETİNİZİ GİRİNİZ : ");
            cnsyt = Console.ReadLine().ToUpper(); 
            Console.Write("DOĞUM YILINIZI GİRİNİZ : ");
            dtr = Convert.ToInt32(Console.ReadLine());
            yas = DateTime.Now.Year - dtr;
            if ( cnsyt == "ERKEK"  &&  yas > 19 )
                

            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ASKERE GİTMEYE HAK KAZANDINIZ");
            
            }

            else 
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ASKERE GİTMEYE HAK KAZANAMADINIZ");
            }
            Console.ReadKey();


            


        }
    }
}
