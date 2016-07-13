using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Point point, double radius) : this(point)
        {
            if (radius < 0)
            {
                throw new ArgumentNullException(nameof(radius));
            }
            Radius = radius;
        }

        private Circle(params Point[] points) : base(points)
        {

        }

        public override double Square() => Math.PI * Radius * Radius;

        public override double Perimeter() => 2 * Math.PI * Radius;
    }
}
