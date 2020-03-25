using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KasappoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaçıncı Ayda Doğdunuz = ");
            int ay = Convert.ToInt16(Console.ReadLine());
            Console.Write("Hangi Gün Doğdunuz = ");
            int gun = Convert.ToInt16(Console.ReadLine());
            
            if (gun >= 21 && ay == 3)
                Console.Write("Koç Burcusunuz");
            else if (gun <= 20 && ay == 4) Console.Write("Koç Burcusunuz");
            else if (gun >= 21 && ay == 4)
                Console.Write("Boğa Burcusunuz");
            else if (gun <= 21 && ay == 5) Console.Write("Boğa Burcusunuz");
            else if (gun >= 22 && ay == 5)
                Console.Write("İkizler Burcusunuz");
            else if (gun <= 22 && ay == 6) Console.Write("İkizler Burcusunuz");
            else if (gun >= 23 && ay == 6)
                Console.Write("Yengeç Burcusunuz");
            else if (gun <= 22 && ay == 7) Console.Write("Yengeç Burcusunuz");
            else if (gun >= 23 && ay == 7)
                Console.Write("Aslan Burcusunuz");
            else if (gun <= 22 && ay == 8) Console.Write("Aslan Burcusunuz");
            else if (gun >= 23 && ay == 8)
                Console.Write("Başak Burcusunuz");
            else if (gun <= 22 && ay == 9) Console.Write("Başak Burcusunuz");
            else if (gun >= 23 && ay == 9)
                Console.Write("Terazi Burcusunuz");
            else if (gun <= 22 && ay == 10) Console.Write("Terazi Burcusunuz");
            else if (gun >= 23 && ay == 10)
                Console.Write("Akrep Burcusunuz");
            else if (gun <= 21 && ay == 11) Console.Write("Akrep Burcusunuz");
            else if (gun >= 22 && ay == 11)
                Console.Write("Yay Burcusunuz");
            else if (gun <= 21 && ay == 12) Console.Write("Yay Burcusunuz");
            else if (gun >= 22 && ay == 12)
                Console.Write("Oğlak Burcusunuz");
            else if (gun <= 20 && ay == 1) Console.Write("Oğlak Burcusunuz");
            else if (gun >= 21 && ay == 1)
                Console.Write("Kova Burcusunuz");
            else if (gun <= 19 && ay == 2) Console.Write("Kova Burcusunuz");
            else if (gun >= 20 && ay == 2)
                Console.Write("Balık Burcusunuz");
            else if (gun <= 21 && ay == 3)
                Console.Write("Balık Burcusunuz");

            else
                Console.Write("Yanlış Değerler Girdiniz !!");

            Console.ReadKey();
        }
    }
}