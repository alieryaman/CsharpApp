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
            string ad, şifre;
            int syc = 0;
        etiket:
            
            Console.Write("KULLANICI ADINIZI GİRİNİZ:  ");
            ad=Console.ReadLine();
            Console.Write("ŞİFRENİZİ GİRİNİZ        :  ");
            şifre=Console.ReadLine();
            syc=syc + 1 ;
            if (ad == "Admin" && şifre == "123")
            {
                Console.WriteLine("HOŞGELDİNİZ :) ");
                Console.ReadKey();
                
            }
                
            else
            {
                {
                    if (syc < 3)

                        goto etiket;

                }



                {
                    Console.Write("ŞİFRENİZ BLOKE OLMUŞTUR");
                }
             
                Console.WriteLine("YANLIŞ GİRİŞ YAPTINIZ");
            }
           
            Console.ReadKey();


        }
    }
}
