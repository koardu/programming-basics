using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string msg = string.Empty;
            Console.Write("Syötä numero: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Syötä kokonaisluku!");
            }
            int odd = 0, even = 0;
            int negative = number < 0 ? -1 : 1;
            for(int i = 1; i <= number * negative; i++)
            {
                {
                    if (i % 2 == 0)
                    {
                        even += i * negative;
                    }
                    else
                    {
                        odd += i * negative;
                    }
                }
                msg = string.Format("Parittomien summa: {0}, Parillisten summa: {1}", odd, even);
            }
            Console.WriteLine("Vastaus: {0}", msg);
            Console.ReadKey();
        }
    }
}
