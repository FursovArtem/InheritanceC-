using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Circle : Shape, IHaveRadius
    {
        double length;
        public double Length
        {
            get { return length; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                length = value;
            }
        }
        public Circle(int length, int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color)
        { Length = length; }

        public double GetDiameter()
        {
            return Length / Math.PI;
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
            return Length;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (int)GetDiameter(), (int)GetDiameter());
            DrawRadius(e);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType());
            base.Info(e);
        }
        public void DrawRadius(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawLine(pen, StartX + (float)GetRadius(), StartY + (float)GetRadius(), StartX, StartY + (float)GetRadius());
        }
    }
}
