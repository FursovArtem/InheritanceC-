using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AbstractGeometry
{
    internal class RightTriangle : Triangle
    {
        double side_a;
        double side_b;
        double hypotenuse;
        public double Side_a
        {
            get { return side_a; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                side_a = value;
            }
        }
        public double Side_b
        {
            get { return side_b; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                side_b = value;
            }
        }
        public double Hypotenuse
        {
            get { return hypotenuse; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value= MAX_LENGTH;
                hypotenuse = value;
            }
        }
        public RightTriangle(double side_a, double side_b, double hypotenuse, int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color)
        {
            Side_a = side_a;
            Side_b = side_b;
            Hypotenuse = hypotenuse;
        }
        public RightTriangle(double side_a, double side_b, int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color)
        {
            Side_a = side_a;
            Side_b = side_b;
            Hypotenuse = Math.Sqrt(Math.Pow(Side_a, 2) + Math.Pow(Side_b, 2));
        }

        public override double GetHeight()
        {
            return Side_a * Side_b / Hypotenuse;
        }
        public override double GetArea()
        {
            return Side_a * Side_b / 2;
        }
        public override double GetPerimeter()
        {
            return Side_a + Side_b + Hypotenuse;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[]
            {
                new Point(StartX, StartY + (int)GetHeight()),
                new Point(StartX + (int)Hypotenuse, StartY + (int)GetHeight()),
                new Point(StartX + (int)(Math.Sqrt(Math.Pow(GetHeight(), 2) + Math.Pow(Side_b, 2)) / Math.Pow(GetHeight(), 2)), StartY)
            };
            e.Graphics.DrawPolygon(pen, points);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Катет a: {Side_a}");
            Console.WriteLine($"Катет b: {Side_b}");
            Console.WriteLine($"Гипотенуза: {Hypotenuse}");
            base.Info(e);
        }
    }
}
