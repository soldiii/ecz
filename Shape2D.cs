using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    abstract class Shape2D : Shape
    {
        public Shape2D(string color) : base(color) { }
        public override void volume(){
            base.volume();
        }
    }
}
