using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    class Square : Shape2D
    {
        private double length;

        public Square(string color, double _length) : base(color)
        {
            length = _length;
        }
        public override void volume()
        {
            base.volume();
            Console.WriteLine($"Площадь  - {Math.Pow(length, 2)}");
        }
    }
}
