using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    public class Car 
    {
        //variables
        private readonly string _brand;
        private double _speed;

        //Constructors
        public Car(string brand)
        {
            _brand = brand;
            _speed = 0;
        }
        //Properties
        public string Brand
        {
            get { return _brand; }
        }

        public double Speed
        {
            get { return _speed; }
            private set { _speed = value; }
        }
        //Methods
        public void Accelerate(double acceleration)
        {
            _speed = _speed + acceleration;
        }

        public void Brake()
        {
            _speed = _speed - 10;
        }

        public override string ToString()
        {
            return Print();
        }

        private string Print()
        {
            return "Brand: " + Brand + ", Speed: " + Speed;
            
        }

    }
}
