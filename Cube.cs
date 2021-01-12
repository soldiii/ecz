using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    class Cube : Shape3D
    {
        private double length;
        public Cube(string color, double _length) : base(color)
        {
            length = _length;
        }
        public override void volume()
        {
            base.volume();
            Console.WriteLine($"Объем - {Math.Pow(length, 3)}");
        }
    }
}

