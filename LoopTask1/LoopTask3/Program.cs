using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string msg = string.Empty;
            Console.Write("Input: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Syötä kokonaisluku!");
            }
            int sumOdd = 0, sumEven = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumEven += i;
                    }
                    else
                    {
                        sumOdd += i;
                    }
                }
                msg = string.Format("Parittomien summa: {0}, Parillisten summa: {1}", sumOdd, sumEven);
            }
            Console.WriteLine("Vastaus: {0}", msg);
            Console.ReadKey();
        }  
        }
    }

