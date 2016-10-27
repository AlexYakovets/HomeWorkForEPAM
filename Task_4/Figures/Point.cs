using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Figures
{
  public class Point
    {
        private int x;
        private int y;
        public int X { get; }
        public int Y { get; }

        public Point(int A, int B )
        {
            this.X = A;
            this.Y = B;
        }
    }
}
