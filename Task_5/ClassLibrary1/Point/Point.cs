using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary1.Point
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
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
