using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double area 
        { 
            get
            {
                const double pie = 3.14;
                return _radius * _radius * pie;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Radius: {_radius}");
            Console.WriteLine($"Area: {area:F2}");
        }
    }
}
