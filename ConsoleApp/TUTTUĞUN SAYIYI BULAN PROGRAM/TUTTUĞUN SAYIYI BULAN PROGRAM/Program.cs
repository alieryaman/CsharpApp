using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTTUĞUN_SAYIYI_BULAN_PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("AKLINDAN BİR SAYI TUT");
            Console.ReadKey();
            Console.WriteLine("TUTTUĞUN SAYIYI 3 İLE ÇARP");
            Console.ReadKey();
            Console.WriteLine("SONRA 5 EKLE");
            Console.ReadKey();
            Console.Write("SONUCU YAZINIZ : ");
            y = Convert.ToInt32(Console.ReadLine());
            x = (y - 5) / 3;
            Console.WriteLine("TUTTUĞUNUZ SAYI : " + x);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("BİZ HER ŞEYİ BİLİRİZ ;)");
            Console.ReadKey();
            
        }
    }
}
