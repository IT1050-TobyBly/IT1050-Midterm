using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boolean keeplooping = true;
            while (keeplooping)
            {
              Console.WriteLine("This will never end");
            }

            int loop = 2;
            while (loop < 128)
            {
                Console.WriteLine("[" + loop + "]");
                    loop = loop + loop;
            }

            for (int j = 49; j > 0; j--)
            {
                Console.Write(j);
                if (j != 1)
            {
                Console.Write(",");
            }
            }

            int i = 1;
            while (i <=21)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(" ");
                }
                else if ((i % 2) != 0)
                {
                    Console.Write(i);
                }
                i++;
            }

            int n = 8;
            int p = 10; // initialize
            do
            {
                Console.Write("*");
                p++; // update!
            } while (p < n); // test condition

            {
                bool icyRain = false, tornadowarning = false;
                // bool tornadowarning = false;
                if( icyRain == false && tornadowarning == false)
                {
                    Console.WriteLine("Lets go outside");
                }

                {
                    int numberoflayer = 5, Space, Number;
                    Console.WriteLine("Print pyramid");
                    for (int k = 1; k <= numberoflayer;k++)
                    {
                        for (Space = 1; Space <= (numberoflayer - i); Space++)
                            Console.Write("");
                        for (Number = 1; Number <= k; Number++)
                            Console.Write(Number);
                        for (Number = (k - 1); Number >= 1; Number--)
                            Console.Write(Number);
                        Console.WriteLine();
                    }

                }

            }


        }


    }
}
