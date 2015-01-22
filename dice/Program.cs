using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int antal = 0;
            int kast = 0;
            Random tarning = new Random();
            int[] frekvenstabell = new int[6];
            string[] sidnamn = { "ettor", "tvåor", "treor", "fyror", "femmor", "sexor" };

            do
            {
            Console.Write("Ange antal tärnings kast [100-1000]: ");
            }while (!(int.TryParse(Console.ReadLine(), out antal) && antal >=100 && antal <= 1000 ));

            for (int i = 0; i < antal; i++)
            
                {
                    frekvenstabell[tarning. Next(0, 6)]++;
                }
                
                for (int i = 0; i < sidnamn.Length; i++)
                {
                    Console.WriteLine("{0}: {1}", sidnamn[i], frekvenstabell[i]);
                }


                // kast = tarning.Next(1, 7);
                // Console.WriteLine(kast);
            }

        }

    }





