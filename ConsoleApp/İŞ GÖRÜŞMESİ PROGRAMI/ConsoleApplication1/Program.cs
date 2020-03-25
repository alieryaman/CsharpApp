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
            string ad, syd, cnsyt, cvp1, cvp2, kadn1, kadn2;
            int dtrh, yas;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("             by VEYSEL KARTALMIŞ                    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ADINIZI GİRİNİZ          : ");
            ad = Console.ReadLine();
            Console.Write("SOYADINIZI GİRİNİZ       : ");
            syd = Console.ReadLine();
            Console.Write("CİNSİYETİNİZİ GİRİNİZ (ERKEK/KADIN)   : ");
            cnsyt = Console.ReadLine();
            
            Console.Write("DOĞUM TARİHİNİZİ GİRİNİZ : ");
            dtrh = Convert.ToInt32(Console.ReadLine());

            yas = 2014 - dtrh;

            if (cnsyt == "ERKEK")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ASKERLİĞİNİ YAPTIN MI ? (EVET/HAYIR) :  ");
                cvp1 = Console.ReadLine();
                Console.Write("EHLİYETİN VAR MI ?   (EVET/HAYIR)    :  ");
                cvp2 = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("             by VEYSEL KARTALMIŞ                    ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                if ((cvp1 == "EVET") && (cvp2 == "EVET"))
                {
                    Console.WriteLine("MERHABA ADINIZ  : " + ad);
                    Console.WriteLine("SOYADINIZ       : " + syd);
                    Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                    Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                    Console.WriteLine("YAŞINIZ         : " + yas);
                    Console.WriteLine("1250 LİRA MAAŞLA İŞE BAŞLAYABİLİRSİNİZ");
                    
                }
                
                
                    if ((cvp1 == "EVET ") && (cvp2 == "HAYIR"))
                    {
                        Console.WriteLine("MERHABA ADINIZ  : " + ad);
                        Console.WriteLine("SOYADINIZ       : " + syd);
                        Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                        Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                        Console.WriteLine("YAŞINIZ         : " + yas);
                        Console.WriteLine("1000 LİRA MAAŞLA İŞE BAŞLAYABİLİRSİNİZ");
                    }
                    else
                    {
                        if ((cvp1 == "HAYIR") && (cvp2 == "EVET")) 
                        {
                            Console.WriteLine("MERHABA ADINIZ  : " + ad);
                            Console.WriteLine("SOYADINIZ       : " + syd);
                            Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                            Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                            Console.WriteLine("YAŞINIZ         : " + yas);
                            Console.WriteLine("ASKERLİĞİNİ YAPTA GEL");
                        }
                    }
                    if ((cvp1 == "HAYIR") && (cvp2 == "HAYIR")) 
                    {
                        Console.WriteLine("MERHABA ADINIZ  : " + ad);
                        Console.WriteLine("SOYADINIZ       : " + syd);
                        Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                        Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                        Console.WriteLine("YAŞINIZ         : " + yas);
                        Console.WriteLine("MAALESEF İŞE ALAMAYIZ");
                    }
                   
              
                        
                        
                    }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (cnsyt == "KADIN")
                {
                    Console.Write("EVLİ MİSİNİZ   (EVET/HAYIR)     : ");
                    kadn1 = Console.ReadLine();
                    Console.Write("EHLİYETİNİZ VAR MI (EVET/HAYIR) : ");
                    kadn2 = Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("----------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("             by VEYSEL KARTALMIŞ                    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    if ((kadn1 == "EVET") && (kadn2 == "EVET"))
                    {
                        Console.WriteLine("MERHABA ADINIZ  : " + ad);
                        Console.WriteLine("SOYADINIZ       : " + syd);
                        Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                        Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                        Console.WriteLine("YAŞINIZ         : " + yas);
                        Console.WriteLine("1250 LİRA MAAŞLA İŞE ALINDINIZ");

                    }
                    else
                    {
                        if ((kadn1 == "HAYIR") && (kadn2 == "HAYIR"))
                        {
                            Console.WriteLine("MERHABA ADINIZ  : " + ad);
                            Console.WriteLine("SOYADINIZ       : " + syd);
                            Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                            Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                            Console.WriteLine("YAŞINIZ         : " + yas);
                            Console.WriteLine("İŞE ALINMADINIZ");
                        }
                        if ((kadn1 == "EVET") && (kadn2 == "HAYIR"))
                        {
                            Console.WriteLine("MERHABA ADINIZ  : " + ad);
                            Console.WriteLine("SOYADINIZ       : " + syd);
                            Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                            Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                            Console.WriteLine("YAŞINIZ         : " + yas);
                            Console.WriteLine("1000 LİRA MAAŞLA İŞE ALINDINIZ");
                        }
                        else
                        {
                            if ((kadn1 == "HAYIR") && (kadn2 == "EVET"))
                            {
                                Console.WriteLine("MERHABA ADINIZ  : " + ad);
                                Console.WriteLine("SOYADINIZ       : " + syd);
                                Console.WriteLine("CİNSİYETİNİZ    : " + cnsyt);
                                Console.WriteLine("DOĞUM TARİHİNİZ : " + dtrh);
                                Console.WriteLine("YAŞINIZ         : " + yas);
                                Console.WriteLine("1000 LİRA MAAŞLA İŞE ALINDINIZ");
                            }
                        }
                    }
                }
            }

           




            Console.ReadKey();
                }
        
            }
            
        }
    


