using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    class Circle : Shape2D
    {
        private double radius;
        public Circle(string color, double _radius) : base(color)
        {
            radius = _radius;
        }
        public override void volume()
        {
            base.volume();
            Console.WriteLine($"Площадь - {Math.PI * Math.Pow(radius, 2)}");
        }
    }
}
