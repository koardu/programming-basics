using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print text to screen
            Console.WriteLine("Type your firstname:");
            string strFName = Console.ReadLine();
            Console.WriteLine("Type your lastname:");
            string strLName = Console.ReadLine();
            //Console.WriteLine("Your name is " + strName);
            Console.WriteLine("Your name is {0} and lastname {1}", strFName,strLName);
            Console.ReadKey();
        }
    }
}
