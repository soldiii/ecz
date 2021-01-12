using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    abstract class Shape3D : Shape
    {
        public Shape3D(string color) : base(color) { }
        public override void volume() {
            base.volume();
        }
    }
}
