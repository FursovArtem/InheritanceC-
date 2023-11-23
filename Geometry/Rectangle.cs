using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Height, 2));
        }
        public override double GetArea()
        {
            return Length * Height;
        }
        public override double GetPerimeter()
        {
            return Length * 2 + Height * 2;
        }
        public override void Draw()
        {
            
        }
    }
}
