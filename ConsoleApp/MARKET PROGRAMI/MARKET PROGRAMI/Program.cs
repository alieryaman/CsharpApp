using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARKET_PROGRAMI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stok = new int[5] {10,5,15,20,30};

            string[] ürünler = new string[5] { "1-) 4 GB RAM = 100 TL", "2-)EKRAN KARTI = 150 TL", "3-) ANAKART = 340 TL  ", "4-)MAUSE = 25 TL ", "5-)KLAVYE = 20 TL" };
            int[] fiyat = new int[5] { 100, 150, 340, 25, 20 };
            Console.Write("ADINIZ    : ");
            string ad = Console.ReadLine();
            Console.Write("SOYADINIZ : ");
            string soyad = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ürünler[i]);
            }
            string scm;
            int tfiyat = 0;
        start:
            Console.Write("SEÇİMİNİZ = ");
            scm = Console.ReadLine();
            switch (scm)
            {
                case "1":
                    tfiyat = tfiyat + fiyat[0];
                    Console.WriteLine("ŞU ANLIK TUTAR : {0} TL", tfiyat);
                    stok[0] = stok[0] - 1;
                    Console.WriteLine("KALAN STOK: {0}", stok[0]);
                    break;
                case "2":
                    tfiyat = tfiyat + fiyat[1];
                    Console.WriteLine("ŞU ANLIK TUTAR : {0} TL", tfiyat);
                    stok[1] = stok[1] - 1;
                    Console.WriteLine("KALAN STOK: {0}", stok[1]);
                    break;
                case "3":
                    tfiyat = tfiyat + fiyat[2];
                    Console.WriteLine("ŞU ANLIK TUTAR : {0} TL", tfiyat);
                    stok[2] = stok[2] - 1;
                    Console.WriteLine("KALAN STOK: {0}", stok[2]);
                    break;
                case "4":
                    tfiyat = tfiyat + fiyat[3];
                    Console.WriteLine("ŞU ANLIK TUTAR : {0} TL", tfiyat);
                    stok[3] = stok[3] - 1;
                    Console.WriteLine("KALAN STOK: {0}", stok[3]);
                    break;
                case "5":
                    tfiyat = tfiyat + fiyat[4];
                    Console.WriteLine("ŞU ANLIK TUTAR : {0} TL", tfiyat);
                    stok[4] = stok[4] - 1;
                    Console.WriteLine("KALAN STOK: {0}", stok[4]);
                    break;
                default:
                    Console.WriteLine("1-5 ARASI RAKAM GİRİNİZ:");
                    break;
            }
            string scm2;
            Console.Write("ALIŞVERİŞE DEVAM ETMEK İSTİYOSAN 1 İSTEMİYOSAN 2 = ");
            scm2 = Console.ReadLine();
            if (scm2 == "1")
            {
                goto start;
            }
            else
            {
                Console.WriteLine("MERHABA {0} {1} ;", ad, soyad);
                Console.WriteLine("TUTAR = " + tfiyat);
            }
            Console.ReadKey();


        }
    }
}
    