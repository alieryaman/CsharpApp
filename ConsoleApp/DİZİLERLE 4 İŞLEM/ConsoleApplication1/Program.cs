using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DİZİLERLETOPLAMAİŞLEMİ
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dizi1 = new int[5];
            int[] dizi2 = new int[5];
            int[] dizitop = new int[5];
            int[] dizicik = new int[5];
            int[] dizicarp = new int[5];
            int[] dizibol = new int[5];
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < 5; i++)
            {
               
                Console.Write("BİRİNCİ DİZİNİN "+(i + 1) + ". ELEMANINI GİRİNİZ:");
                dizi1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" ");
            for (int j = 0; j < 5; j++)
            {                              
                Console.Write("İKİNCİ DİZİNİN" +(j + 1) + ". ELEMANINI GİRİNİZ:");
                dizi2[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
			{
			 dizitop[i]=dizi1[i]+dizi2[i];
             dizicik[i]=dizi1[i]-dizi2[i];
             dizicarp[i]=dizi1[i]*dizi2[i];
             dizibol[i]=dizi1[i]/dizi2[i];
			}

            Console.WriteLine(" ");
            Console.WriteLine(" TOPLAMA İÇİN -------> 1 ");
            Console.WriteLine(" ÇIKARMA İÇİN -------> 2 ");
            Console.WriteLine(" ÇARPMA İÇİN  -------> 3 ");
            Console.WriteLine(" BÖLME İÇİN   -------> 4 ");
            veysel:
            Console.Write("SEÇİMİNİZ : ");
            string secım = Console.ReadLine();

            switch (secım)
            {
                case "1":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" {0} + {1} = {2} ", dizi1[i], dizi2[i], dizitop[i]);
                    }
                    break;
                case "2":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" {0} - {1} = {2} ", dizi1[i], dizi2[i], dizicik[i]);
                    }
                    break;
                case "3":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" {0} X {1} = {2} ", dizi1[i], dizi2[i], dizicarp[i]);
                    }
                    break;
                case "4":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" {0} / {1} = {2} ", dizi1[i], dizi2[i], dizibol[i]);
                    }
                    break;

                default:
                    Console.WriteLine("1-4 ARASI BİR RAKAM GİRİNİZ !");
                    goto veysel;
                    
                    
            }

            Console.ReadKey();
        }
    }
}
