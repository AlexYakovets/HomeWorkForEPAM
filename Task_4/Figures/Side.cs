using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
   public class Side
    {
        public Point aPoint{get; set;}
        public Point bPoint{get; set;}



        public Side(Point a, Point b)
        {
            aPoint = a;
            bPoint = b;
        }

       public double Length()
       {
           return Math.Sqrt(Math.Abs(aPoint.x - bPoint.x) + Math.Abs(aPoint.y - bPoint.y));
       }
    }

    public static class Intersection
    {
        public static bool sidesIsIntersect(Side a, Side b)
        {
            PointEqualityComparer PointsComparer=new PointEqualityComparer();
            if (PointsComparer.Equals(a.aPoint, b.aPoint) || PointsComparer.Equals(a.bPoint, b.aPoint) || PointsComparer.Equals(a.aPoint, b.bPoint) ||
               PointsComparer.Equals(a.bPoint, b.bPoint))
                return true;
            else return false;
        }
    }
}
