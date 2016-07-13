using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Shape
    {
        public Point[] points;

        public int Count
        {
            get { return points.Length; }
        }

        public Shape(params Point[] points)
        {
            if (points == null)
            {
                throw new ArgumentNullException(nameof(points));
            }
            this.points = new Point[points.Length];
            Array.Copy(points, this.points, points.Length);
        }

        public abstract double Square();

        public abstract double Perimeter();
    }
}
