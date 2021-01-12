using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
     abstract class Shape
    {
        private string color;

        public Shape(string _color)
        {
            color = _color;
        }

        public virtual void volume() {
            Console.WriteLine($"Цвет - {color}");
        }
    }
}
