using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace functions1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Type number: ");
            int number = 0;
            bool result = int.TryParse(Console.ReadLine(), out number);
            string msg = String.Empty;
            if (IsPositiveNumber(number))
            {
                MakeMsg(number, ref msg);
            }
            else
            {
                msg = $"Invalid number: {number}";
            }
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        private static bool IsPositiveNumber(int num)
        {
            return num > 0;
        }


        public static void MakeMsg(int num, ref string msg)
            {
                for (int i = 0; i < num; i++)
                {
                    msg = msg + "*";
                }
            }
        }
    }
