using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Shapes;
namespace Figures
{
    
    public class Triangle:Figure
    {
 
        public static int countOfSides()
        {
            return 3;
        }
        private Side[] sides = new Side[2];

        public Side sideA {
            get { return sides[0]; } 
            set { sides[0] = value; }
        }
        public Side sideB
        {
            get { return sides[1]; }
            set { sides[1] = value; }
        }
        public Side sideC
        {
            get { return sides[2]; }
            set { sides[2] = value; }
        }


        public override double Perimeter()
        {
            return (sideA.Length() + sideB.Length() + sideC.Length());
        }
        public override double Square()
        {
            double semiPerimetr = this.Perimeter()/2;
            return (Math.Sqrt(semiPerimetr*(semiPerimetr-sideA.Length())*(semiPerimetr - sideB.Length()) *(semiPerimetr - sideC.Length())));
        }

        private List<Line> TriangleToLines(Triangle triangle)
        {

            foreach (var side in triangle.s)
            {

            }
            List<Line> listOfLines = new List<Line>();
          
            return listOfLines;
        }
    }

   public class CreateTriangle : Creator
    {
        public override Figure Create()
        {
            return new Triangle();
        }

        public override Figure Create(Side a, Side b, Side c)
        {
            return new Triangle() {sideA = a, sideB = b, sideC = c};
        }
    }

}
