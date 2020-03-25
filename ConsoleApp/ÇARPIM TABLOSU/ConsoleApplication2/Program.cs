using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc,sayı;
            Console.Write("BİR SAYI GİRİNİZ : ");
            sayı = Convert.ToInt32(Console.ReadLine());
            for (int i = 0 ; i < 11; i++)
            {
                sonuc = i * sayı;
                Console.WriteLine("{0} X {1} = {2}", sayı, i, sonuc);
            }
            Console.ReadKey();
        }
    }
}
