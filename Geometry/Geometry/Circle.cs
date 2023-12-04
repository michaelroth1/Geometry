using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Shape
    {
        public Circle(double r)
        {
            this.R = r;
        }

        public double R { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.R, 2);
        }
    }
}
