using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Circle : Shape
    {
        public double Side { get; set; }
        public Circle(double side) 
        { 
            Side = side;
        }

        public double GetDiameter()
        {
            return Side / Math.PI;
        }
        public double GetRadius()
        {
            return GetDiameter() / 2;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(GetRadius(), 2);
        }
        public override double GetPerimeter()
        {
            return Side;
        }
        public override void Draw()
        {
            
        }
    }
}
