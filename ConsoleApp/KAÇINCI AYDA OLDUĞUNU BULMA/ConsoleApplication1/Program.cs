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
        
            string ay;
            Console.Write("HANGİ AYDASIN ? : ");
            ay = Console.ReadLine();

            switch (ay)
            {
                case "OCAK":
                    Console.WriteLine("1. AYDASIN");
                    break;
                case "ŞUBAT":
                    Console.WriteLine("2. AYDASIN");
                    break;
                case "MART":
                    Console.WriteLine("3. AYDASIN");
                    break;
                case "NİSAN":
                    Console.WriteLine("4 AYDASIN");
                    break;
                case "MAYIS":
                    Console.WriteLine("5. AYDASIN");
                    break;
                case "HAZİRAN":
                    Console.WriteLine("6. AYDASIN");
                    break;
                case "TEMMUZ":
                    Console.WriteLine("7. AYDASIN");
                    break;
                case "AĞUSTOS":
                    Console.WriteLine("8. AYDASIN");
                    break;
                case "EYLÜL":
                    Console.WriteLine("9. AYDASIN");
                    break;
                case "EKİM":
                    Console.WriteLine("10. AYDASIN");
                    break;
                case "KASIM":
                    Console.WriteLine("11. AYDASIN");
                    break;
                case "ARALIK":
                    Console.WriteLine("12. AYDASIN");
                    break;

                


            }



            Console.ReadKey();
        }
    }
}
