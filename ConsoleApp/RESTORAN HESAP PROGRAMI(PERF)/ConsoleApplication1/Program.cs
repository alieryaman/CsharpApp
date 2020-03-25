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
            int hesap=0, secim,secim1,secim2;
            string[] yemekler = new string[5] { "Kebap", "İskender", "Döner", "Urfa Kebap","Dürüm" };
            string[] sıcaklar = new string[3] { "Yayla Çorbası","Ezogelin Çorbası","İşkembe Çorbası" };
            string[] icecekler= new string[4]  { "Kola","Ayran","Şalgam","Ice Tea"};
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          Veysel Ocakbaşı Since 1990             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ANA YEMEKLER : "+ (yemekler[i]));
            }
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("ARA SICAKLAR : "+(sıcaklar[i]));
            }
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("İÇECEKLERİMİZ : "+icecekler[i]);
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fiyat Listesini Görmek İçin Enter'a Basınız :)");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          Veysel Ocakbaşı Since 1990             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("ANA YEMEKLER :  ");
            Console.WriteLine("Kebap      ----> 1  FİYATI:10 TL");
            Console.WriteLine("İskender   ----> 2  FİYATI:12 TL");
            Console.WriteLine("Döner      ----> 3  FİYATI:5 TL");
            Console.WriteLine("Urfa Kebap ----> 4  FİYATI:10 TL");
            Console.WriteLine("Dürüm      ----> 5  FİYATI:7 TL");

            Console.Write("Ana Yemeklerden İstediğinizin Numarasını Giriniz: ");
            secim = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          Veysel Ocakbaşı Since 1990             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            switch(secim)
            {
                case 1 :
                    Console.Write("Kebap Güzel Seçim Hesaba 10 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 10;
                    
                    break;
                case 2:
                    Console.WriteLine("İskender Güzel Seçim Hesaba 12 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 12;
                    
                    break;
                case 3:
                    Console.WriteLine("Döner Güzel Seçim Hesaba 5 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 5;
                    
                    break;
                case 4:
                    Console.WriteLine("Urfa Kebap Güzel Seçim Hesaba 10 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 10;
                    
                    break;
                case 5:
                    Console.WriteLine("Dürüm Güzel Seçim Hesaba 7 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 7;
                    
                    break;
                default:
                    Console.WriteLine("1-5 ARASI BİR RAKAM GİRİNİZ !");
                    break;
            }
            Console.WriteLine("ARA SICAKLAR :  ");
            Console.WriteLine("Yayla Çorbası    ----> 1  FİYATI:3 TL");
            Console.WriteLine("Ezogelin Çorbası ----> 2  FİYATI:3 TL");
            Console.WriteLine("İşkembe Çorbası  ----> 3  FİYATI:3 TL");
            veysel2:
            Console.Write("Ara Sıcaklardan İstediğinizin Numarasını Giriniz: ");
            secim1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          Veysel Ocakbaşı Since 1990             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
           

            switch (secim1)
            {
                case 1:
                    Console.WriteLine("Bu çorba iyi gider :) Hesaba 3 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 3;
                    
                    break;
                case 2:
                    Console.WriteLine("Bu çorba iyi gider :) Hesaba 3 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 3;
                    
                    break;
                case 3:
                    Console.WriteLine("Bu çorba iyi gider :) Hesaba 3 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 3;
                   
                    break;
                default:
                    Console.WriteLine("1-3 ARASI BİR RAKAM GİRİNİZ !");
                    goto veysel2;
            }
            Console.WriteLine("İÇECEKLERİMİZ :  ");
            Console.WriteLine("Kola    ----> 1  FİYATI:2 TL");
            Console.WriteLine("Ayran   ----> 2  FİYATI:1 TL");
            Console.WriteLine("Şalgam  ----> 3  FİYATI:3 TL");
            Console.WriteLine("Ice Tea ----> 4  FİYATI:2 TL");
            veysel3:
            Console.Write("İçeceklerden İstediğinizin Numarasını Giriniz: ");
            secim2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          Veysel Ocakbaşı Since 1990             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;

            switch (secim2)
            {
                case 1:
                    Console.WriteLine("Buz gibi kola :) Hesaba 2 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 2;
                    
                    break;
                case 2:
                    Console.WriteLine("Buz gibi ayran :) Hesaba 1 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 1;
                    
                    break;
                case 3:
                    Console.WriteLine("Çok acı şalgam :) Hesaba 3 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 3;
                    
                    break;
                case 4:
                    Console.WriteLine("Buz gibi ıce tea :) Hesaba 2 lira eklendi. Afiyet olsun!");
                    hesap = hesap + 2;
                    
                    break;
                default:
                    Console.WriteLine("1-4 ARASI BİR RAKAM GİRİNİZ !");
                    goto veysel3;
                    
            }

            Console.WriteLine("MERHABA HALA YEMEK Mİ YİYORSUN ?");
            Console.WriteLine("SORUN DEĞİL :)");
            Console.WriteLine("BİTTİĞİ ZAMAN ENTER'A BAS VE HESABI ÖDEYEBİLİRSİN :)");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          Veysel Ocakbaşı Since 1990             ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("TEKRAR MERHABA TUTARINIZ : {0}",hesap);
            Console.WriteLine("MEMNUN KALDIYSAN YİNE BEKLERİZ :) ");
            Console.ReadKey();


           
            

           


            

        }
    }
}
