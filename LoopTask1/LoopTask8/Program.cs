﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvotaan 20 satunnaista lukua väliltä 0-50.");

            Random rnd = new Random();
            int i = 0;
            while (i < 20)
            {
                if (i % 5 == 0)
                {
                    Console.Write("\nRivi {0}: ", i / 5 + 1);
                }
                else
                {
                    Console.Write(", ");
                }
                Console.Write("{0}", rnd.Next(50));
                i++;
            }
            Console.ReadKey();
        }
    }
}
