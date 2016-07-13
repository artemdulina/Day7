using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Triangle : Shape
    {
        private readonly double[] sides;

        public Triangle(Point x, Point y, Point z) : this(new[] { x, y, z })
        {

        }

        private Triangle(params Point[] points) : base(points)
        {
            sides = new double[points.Length];
            sides[0] = Math.Sqrt(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2));
            sides[1] = Math.Sqrt(Math.Pow(points[2].x - points[1].x, 2) + Math.Pow(points[2].y - points[1].y, 2));
            sides[2] = Math.Sqrt(Math.Pow(points[2].x - points[0].x, 2) + Math.Pow(points[2].y - points[0].y, 2));
        }

        public override double Square()
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
        }

        public override double Perimeter()
        {
            double sum = 0;
            foreach (double side in sides)
            {
                sum += side;
            }
            return sum;
        }

    }
}
