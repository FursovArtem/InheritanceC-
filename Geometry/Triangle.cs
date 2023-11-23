using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal abstract class Triangle : Shape
    {
        public abstract double Cathetus { get; set; }
        public abstract double Hypothenuse { get; set; }
    }
}
