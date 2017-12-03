using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Rectangle: Polygon, IComparable
    {
        public event EventHandler Changed;

        private double length { get; set; }
        private double width { get; set; }

        //public Rectangle(double l, double w)
        //{
        //    length = l;
        //    width = w;
        //}


        public double GetArea()
        {
            return length * width;
        }
        public static string ShapeName
        {
            get { return "Rectangle"; }
        }
        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                Changed(this, EventArgs.Empty);
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                Changed(this, EventArgs.Empty);
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing: Rectangle");
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (!(obj is Rectangle))
                throw new ArgumentException();

            Rectangle target = (Rectangle)obj;
            double diff = this.GetArea() - target.GetArea();
            if (diff == 0)
                return 0;
            else if (diff > 0)
                return 1;
            else return -1;            
        }
    }

    struct Point
    {
        public double X, Y;
    }
}
