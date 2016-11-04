using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClassLibrary1.Point;

namespace ClassLibrary1
{

    public class Vector
    {
        private Point.Point pointA;
        private Point.Point pointB;

        public Point.Point A
        {
            get { return this.pointA; }
            set { this.pointA = value; }
        }
        public Point.Point B
        {
            get { return this.pointB; }
            set { this.pointB = value; }
        }


        public Vector(Point.Point p1, Point.Point p2)
        {
            this.pointA = p1;
            this.pointB = p2;
        }

        public static bool IsIntersect(Vector v1, Vector v2)
        {
            if ((v1.pointA == v2.pointA) || (v1.pointA == v2.pointB) || (v1.pointB == v2.pointA) || (v1.pointB == v2.pointB)) return true;
            else return false;
        }

        public static bool TryFindIntersect(Vector v1, Vector v2, ref Point.Point pointOfIntersect)
        {
            PointEqualityComparer comparer=new PointEqualityComparer();
            if (comparer.Equals(v1.pointA,v2.pointA) || comparer.Equals(v1.pointA,v2.pointB))
            {
                pointOfIntersect = v1.pointA;
                return true;
            }
            else if (comparer.Equals(v1.pointB,v2.pointA) || comparer.Equals(v1.pointB,v2.pointB))
            {
                pointOfIntersect = v1.pointB;
                return true;
            }
            else return false;
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(Math.Abs(pointA.x - pointB.x), 2) + Math.Pow(Math.Abs(pointA.y - pointB.y), 2));
        }

        public static double operator ^(Vector vec1, Vector vec2)
        {
            int x1 = vec1.pointA.x;
            int x2 = vec1.pointB.x;
            int x3 = vec2.pointA.x;
            int x4 = vec2.pointB.x;
            int y1 = vec1.pointA.y;
            int y2 = vec1.pointB.y;
            int y3 = vec2.pointA.y;
            int y4 = vec2.pointB.y;
            double t = (x1*x2*x3*x4 + y1*y2*y3*y4) / (Math.Sqrt((double)x1 * x1 + y1 * y1) * Math.Sqrt((double)x2 * x2 + y2 * y2)* 
                Math.Sqrt((double)x3 * x3 + y3 * y3)*Math.Sqrt((double)x4 * x4 + y4 * y4));
            if (t < -1) t = -1;
            else if (t > 1) t = 1;
            return Math.Acos(t);
        }

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            Point.Point a, b = new Point.Point();
            Point.Point pointOfIntersect=new Point.Point();
            if (TryFindIntersect(vec1, vec2, ref pointOfIntersect))
            {
                a=new Point.Point(vec1.pointA.x+vec2.pointA.x,vec1.pointA.y+vec2.pointA.y);
                b = new Point.Point(vec1.pointB.x + vec2.pointB.x, vec1.pointB.y + vec2.pointB.y);
                return new Vector(a, b);
            }
            else throw new Exception("Vectors isn't intersect");
        }
        public static Vector operator -(Vector vec1, Vector vec2)
        {
            Point.Point a, b = new Point.Point();
            Point.Point pointOfIntersect = new Point.Point();
            if (TryFindIntersect(vec1, vec2, ref pointOfIntersect))
            {
                a = new Point.Point(vec1.pointA.x - vec2.pointA.x, vec1.pointA.y - vec2.pointA.y);
                b = new Point.Point(vec1.pointB.x - vec2.pointB.x, vec1.pointB.y - vec2.pointB.y);

                return new Vector(a, b);
            }
            else throw new Exception("Vectors isn't intersect");
        }
        public static double operator *(Vector vec1, Vector vec2)
        {
            
            Point.Point pointOfIntersect = new Point.Point();
            if (TryFindIntersect(vec1, vec2, ref pointOfIntersect))
            {
                return vec1.Length()*vec2.Length()*Math.Cos(vec1 ^ vec2);

            }
            else throw new Exception("Vectors isn't intersect");
        }
        public string ToString()
        {
            return "point a: x=" + this.pointA.x.ToString() + " y=" + this.pointA.y.ToString() +
                   "point b: x=" + this.pointB.x.ToString() + " y=" + this.pointB.y.ToString();
        }

    }

    public class Vectors
    {
        private Vector[] vectors;

        public Vectors()
        {
            vectors=new Vector[]{new Vector(new Point.Point(1,1),new Point.Point(4,5) ),
                                new Vector(new Point.Point(4,5),new Point.Point(5,6) ),
                                new Vector(new Point.Point(9,10),new Point.Point(5,6))};

        }
        public int Length
        {
            get { return vectors.Length; }
        }
        public Vector this[int index]
        {
            get
            {
                return vectors[index];
            }
            set
            {
                
                vectors[index] = value;
            }
        }

        public IEnumerable GetVectors(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == vectors.Length)
                {
                    yield break;
                }
                else
                {
                    yield return vectors[i];
                }
            }
        }



    }
}
