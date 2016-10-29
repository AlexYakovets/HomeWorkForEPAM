using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Figures
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int A, int B)
        {
            this.x = A;
            this.y = B;
        }


    }

   public class PointEqualityComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point a, Point b)
        {
            if ((a.x == b.x) && (a.y == b.y))
                return true;
            else return false;
        }

        public int GetHashCode(Point p)
        {
            int hCode = (p.x*p.y);
            return hCode.GetHashCode();
        }
    }

}
