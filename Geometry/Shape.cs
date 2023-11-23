using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw();
    }
}
