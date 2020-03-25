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
            string ad, şifre, hyvn, grs, yşifre;
            int syc = 0;
        veysel:

            Console.Write("KULLANICI ADINIZI GİRİNİZ:  ");
            ad = Console.ReadLine();
            Console.Write("ŞİFRENİZİ GİRİNİZ        :  ");
            şifre = Console.ReadLine();
            syc = syc + 1;
            if (ad == "VEYSELKARTALMS" && şifre == "1905")
            {
                Console.WriteLine("HOŞGELDİNİZ :) ");
                Console.ReadKey();

            }

            else
            {
                {
                    if (syc < 3)

                        goto veysel;

                }



                {
                    Console.WriteLine("ŞİFRENİZ BLOKE OLMUŞTUR");
                }

                Console.WriteLine("LÜTFEN GÜVENLİK SORUSUNU CEVAPLAYINIZ :");
                Console.Write("İLK HAYVANINIZIN ADI NEDİR ? : ");
                hyvn = Console.ReadLine();
                if (hyvn == "KARABAŞ")
                {
                    Console.WriteLine("TEBRİKLER DOĞRU BİLDİNİZ !");
                    Console.Write("YENİ ŞİFRENİZİ BELİRLEYİNİZ : ");
                    yşifre = Console.ReadLine();
                    Console.WriteLine("İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞTİRİLDİ !");
                    Console.WriteLine("TEKRAR GİRİŞ YAPMAK İÇİN 1 ÇIKIŞ İÇİN 2 :");
                    Console.Clear();
                    grs = Console.ReadLine();
                    if (grs == "1")
                    {

                        Console.Write("KULLANICI ADINIZI GİRİNİZ:  ");
                        ad = Console.ReadLine();
                        Console.Write("ŞİFRENİZİ GİRİNİZ        :  ");
                        şifre = Console.ReadLine();
                        syc = syc + 1;
                        if (ad == "VEYSELKARTALMS" && yşifre == "1999")
                        {
                            Console.WriteLine("HOŞGELDİNİZ :) ");
                            Console.ReadKey();
                        }



                    }
                    else
                    {

                        Console.WriteLine("HOŞGELDİNİZ");
                    }
                }
                else
                {
                    Console.WriteLine("HESABINIZ TAMAMEN KAPATILMIŞTIR");
                    Console.ReadKey();

                }
                Console.ReadKey();


            }
        }
    }
}