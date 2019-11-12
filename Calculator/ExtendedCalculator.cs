using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Calculator
{
    sealed class ExtendedCalculator : BasicCalculator
    {
        public Point Sum(Point point1, Point point2)
        {
            Size size = new Size(point2);

            return Point.Add(point1, size);
            //Point point = new Point();
            //point.x = point1.x + point2.x;

            //point.y = Sum(point1.y, point2.y);

            //return point;
        }

        public Point Subtract(Point point1, Point point2)
        {
            Size size = new Size(point2);
            
            return Point.Subtract(point1, size);
        }
    }
}