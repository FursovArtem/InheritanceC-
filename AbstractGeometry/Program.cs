using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(Console.WindowLeft, Console.WindowTop, Console.WindowWidth, Console.WindowHeight);
            PaintEventArgs e = new PaintEventArgs(graphics, rectangle);

            Rectangle rect = new Rectangle(200, 150, 300, 50, 1, Color.Blue);
            rect.Info(e);
            Square square = new Square(100, 400, 250, 2, Color.Red);
            square.Info(e);
            EquilateralTriangle eq = new EquilateralTriangle(150, 700, 250, 3, Color.Green);
            eq.Info(e);
            Circle c = new Circle(300, 550, 250, 4, Color.Yellow);
            c.Info(e);
            RightTriangle rt = new RightTriangle(150, 250, 550, 50, 3, Color.Crimson);
            rt.Info(e);
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
    }
}
