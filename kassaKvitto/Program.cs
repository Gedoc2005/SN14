using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kassaKvitto
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalBelopp, avrundatBelopp;
            int summa, erthålletBelopp, tillbaka, betala, femhundra, etthundra, femty, tjugo, tio, fem, ett;
            string input;

            while (true)
            {
                try
                {
                    Console.Write("Ange Totalbelopp:    ");
                    input = Console.ReadLine();
                    totalBelopp = double.Parse(input);

                    if (totalBelopp < 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nFEL! Totalsumma är för lite. Köpet kunde inte genomföras\n");
                        Console.ResetColor();

                        return;
                        
                    }
                    
                    break;

                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Är inget Belopp\n");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Ange Erhålletbelopp: ");
                    input = Console.ReadLine();
                    erthålletBelopp = int.Parse(input);
                

                    break;
                }

                catch(Exception)
                {
                    Console.Write("inget som kan tolkast som ett tal");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Erhålletbelopp felatig \n");
                    Console.ResetColor();
                }
            }
            summa = (int)Math.Round(totalBelopp);
            avrundatBelopp = totalBelopp - summa;

            betala = (int)totalBelopp + (int)avrundatBelopp;

            tillbaka = erthålletBelopp - betala;

            if (erthålletBelopp < totalBelopp)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nFEL! Erhålletbelopp är för lite. Köpet kunde inte genomföras. \n");
                Console.ResetColor();
                return;
            }


                Console.WriteLine();

                Console.WriteLine("KVITTO");

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Total           : {0, 15 :c}", totalBelopp);
                Console.WriteLine("Öresavrundning  : {0, 15 :c}", avrundatBelopp);
                Console.WriteLine("Att betala      : {0, 15 :c0}", betala);
                Console.WriteLine("Kontant         : {0, 15 :c0}", erthålletBelopp);
                Console.WriteLine("Tillbaka        : {0, 15 :c0}", tillbaka);
                Console.WriteLine("--------------------------------------------");

                femhundra = tillbaka / 500;
                tillbaka = tillbaka % 500;

                etthundra = tillbaka / 100;
                tillbaka = tillbaka % 100;

                femty = tillbaka / 50;
                tillbaka = tillbaka % 50;

                tjugo = tillbaka / 20;
                tillbaka = tillbaka % 20;

                tio = tillbaka / 10;
                tillbaka = tillbaka % 10;

                fem = tillbaka / 5;
                tillbaka = tillbaka % 5;

                ett = tillbaka / 1;


                if (femhundra > 0)
                {
                    Console.WriteLine("500-lappar :{0}", femhundra);
                }
                if (etthundra > 0)
                {
                    Console.WriteLine("100-lappar :{0}", etthundra);
                }
                if (femty > 0)
                {
                    Console.WriteLine("50-lappar  :{0}", femty);
                }
                if (tjugo > 0)
                {
                    Console.WriteLine("20-lappar  :{0}", tjugo);
                }
                if (tio > 0)
                {
                    Console.WriteLine("10-lappar  :{0}", tio);
                }
                if (fem > 0)
                {
                    Console.WriteLine("5-lappar   :{0}", fem);
                }
                if (ett > 0)
                {
                    Console.WriteLine("1-lappar   :{0}", ett);
                }
            }

    }
}
