using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rectangle : Shape
    {
        private readonly double height;
        private readonly double width;

        public Rectangle(Point a, Point b) : this(new[] { a, b })
        {
            height = Math.Abs(a.y - b.y);
            width = Math.Abs(a.x - b.x);
        }

        private Rectangle(params Point[] points) : base(points)
        {

        }

        public override double Square() => height * width;

        public override double Perimeter() => 2 * (height + width);
    }
}
