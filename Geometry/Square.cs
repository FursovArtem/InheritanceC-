using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public double GetDiagonal()
        {
            return Side * Math.Sqrt(2);
        }
        public override double GetArea()
        {
            return Side * Side;
        }
        public override double GetPerimeter()
        {
            return Side * 4;
        }
        public override void Draw()
        {

        }
    }
}
