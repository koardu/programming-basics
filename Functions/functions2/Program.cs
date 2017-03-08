using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions2
{
    class Program
    {
            static int minimi(int num1, int num2)
            {
                return num1 < num2 ? num1 : num2;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Functions - Task 2.\n");

                int num1, num2;
                Console.Write("Anna luku: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.Write("Anna toinen luku: ");
                int.TryParse(Console.ReadLine(), out num2);

                Console.WriteLine("Minimi: {0}", minimi(num1, num2));
                Console.ReadKey();
            }
    }
}

