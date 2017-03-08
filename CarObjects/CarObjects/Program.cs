using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Volvo");
            Console.WriteLine("Brand: " + car.Brand);
            Console.WriteLine("Default speed: " + car.Speed);
            car.Accelerate(20);
            car.Accelerate(10);
            Console.WriteLine("New speed: " + car.Speed);
            car.Brake();
            Console.WriteLine("Speed after braking: " + car.Speed);
            Console.WriteLine(car);

            Console.ReadKey();
               
        }
    }
}
