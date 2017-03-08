using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions3
{
    class Program
    {
        static int luku(int num1, int num2)
        {
            int n;
            bool res = false;
            do
            {
                Console.Write("Anna luku väliltä {0}-{1}: ", num1, num2);
                res = int.TryParse(Console.ReadLine(), out n);
            } while (!res || n < num1 || n > num2);
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Syötit luvun {0}", luku(-123, 123));
            Console.ReadKey();
        }

    }
}
