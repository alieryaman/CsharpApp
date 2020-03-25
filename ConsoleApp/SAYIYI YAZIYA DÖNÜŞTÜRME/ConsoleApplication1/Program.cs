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
            veysel:
            int bırler=0, onlar=0, yuzler=0, sayı=0, binler=0, tus=0;
            string onlr="", brler="", yzler="", bnler="";
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       YAZDIĞIN SAYIYI OKUYAN PROGRAM     ");
            Console.WriteLine("              VEYSEL KARTALMIŞ            ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.Write("BİR SAYI GİRİNİZ : ");
            sayı = Convert.ToInt32(Console.ReadLine());
            
            binler = sayı / 1000;
            yuzler = (sayı % 1000) / 100;
            onlar = (sayı % 100) / 10;
            bırler = sayı % 10;

            


            switch (binler)
            {
                case 1:
                    bnler = "BİN";
                    break;
                case 2:
                    bnler = "İKİBİN";
                    break;
                case 3:
                    bnler = "ÜÇBİN";
                    break;
                case 4:
                    bnler = "DÖRTBİN";
                    break;
                case 5:
                    bnler = "BEŞBİN";
                    break;
                case 6:
                    bnler = "ALTIBİN";
                    break;
                case 7:
                    bnler = "YEDİBİN";
                    break;
                case 8:
                    bnler = "SEKİZBİN";
                    break;
                case 9:
                    bnler = "DOKUZBİN";
                    break;
            }


            switch (yuzler)
            {
                case 1 :
                yzler = "YÜZ";
                break;
                case 2 :
                yzler = "İKİYÜZ";
                break;
                case 3 :
                yzler = "ÜÇYÜZ";
                break;
                case 4 :
                yzler = "DÖRTYÜZ";
                break;
                case 5 :
                yzler = "BEŞYÜZ";
                break;
                case 6 :
                yzler = "ALTIYÜZ";
                break;
                case 7 :
                yzler = "YEDİYÜZ";
                break;
                case 8 :
                yzler = "SEKİZYÜZ";
                break;
                case 9 :
                yzler = "DOKUZYÜZ";
                break;
            }

            switch (onlar)
            {

                case 1 :
                onlr = "ON";
                break;
                case 2:
                onlr = "YİRMİ";
                break;
                case 3:
                onlr = "OTUZ";
                break;
                case 4:
                onlr = "KIRK";
                break;
                case 5:
                onlr = "ELLİ";
                break;
                case 6:
                onlr = "ALTMIŞ";
                break;
                case 7:
                onlr = "YETMİŞ";
                break;
                case 8:
                onlr = "SEKSEN";
                break;
                case 9:
                onlr = "DOKSAN";
                break;                
            }

            switch (bırler)
            {
                case 1:
                    brler = "BİR";
                    break;
                case 2:
                    brler = "İKİ";
                    break;
                case 3:
                    brler = "ÜÇ";
                    break;
                case 4:
                    brler = "DÖRT";
                    break;
                case 5:
                    brler = "BEŞ";
                    break;
                case 6:
                    brler = "ALTI";
                    break;
                case 7:
                    brler = "YEDİ";
                    break;
                case 8:
                    brler = "SEKİZ";
                    break;
                case 9:
                    brler = "DOKUZ";
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YAZDIĞINIZ SAYININ OKUNUŞU : " + bnler + yzler + onlr + brler );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("DEVAM ETMEK İÇİN 1 BİTİRMEK İÇİN 2 TUŞLAYIN : ");
            tus = Convert.ToInt16(Console.ReadLine());
            if (tus==1)
            {
                Console.Clear();
                goto veysel;
            }
            else
            {
                Console.ReadKey();
            }

            

        }
    }
}
