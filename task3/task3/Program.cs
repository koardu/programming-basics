using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = 0;
            string message = string.Empty;
            Console.Write("This program check is typed number Even or Odd. Type number: ");
            bool result = int.TryParse(Console.ReadLine(), out number);

                if (!result)
                {
                    message = "Not a number";
                }
                else if (number % 2 == 0)
                {
                    message = string.Format("Number {0} is Even, ", number);
                    //message = "Number" + number + "is Even";
                }
                else
                {
                    message = string.Format("Number {0} is Odd, ", number);
                }

           
                string message2 = string.Empty;

                if (number < 0)
                {
                    message2 = string.Format("and it is negative", number);
                }

                else if (number == 0)
                {
                    message2 = string.Format("and it is zero", number);
                }

                else
                 { 
                    message2 = string.Format("and it is positive", number);
                 }

                Console.Write(message);
                Console.Write(message2);
                Console.ReadKey();
            
        }
    }
}
