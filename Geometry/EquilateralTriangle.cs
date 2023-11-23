using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class EquilateralTriangle : Triangle
    {
        public override double Cathetus { get; set; }
        public override double Hypothenuse { get; set; }
        public EquilateralTriangle(double side) 
        {
            Cathetus = side;
            Hypothenuse = side;
        }

        public double GetHeight()
        {
            return Cathetus * Math.Sqrt(3) / 2;
        }
        public override double GetArea()
        {
            return 0.5 * Cathetus * GetHeight();
        }
        public override double GetPerimeter()
        {
            return 3 * Cathetus;
        }
        public override void Draw()
        {
            
        }
    }
}
