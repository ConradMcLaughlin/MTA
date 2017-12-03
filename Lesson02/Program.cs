using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rect = new Rectangle(10.0, 20.0);
            //double area = rect.GetArea();
            //Console.WriteLine("Area of Rectangle: {0}", area);

            //Rectangle r = new Rectangle();
            //r.Changed += new EventHandler(r_Changed);
            //r.Length = 10;

            ////Point p1 = new Point();
            ////p1.X = 10;
            ////p1.Y = 20;
            ////Point p2 = p1;
            ////p2.X = 100;
            ////Console.WriteLine("p1.X = {0}", p1.X);

            ////Rectangle rect1 = new Rectangle(10.0, 20.0);
            ////Rectangle rect2 = rect1;
            //////rect2.Length = 100.0;
            ////Console.WriteLine("rect1.Length = {0}", rect1.Length);

            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());
            polygons.Add(new Triangle());

            foreach (Polygon p in polygons)
            {
                p.Draw();
            }

        }

        private static void r_Changed(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            Console.WriteLine("Value Changed: Length = {0}", r.Length);
        }
    }
}
