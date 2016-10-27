using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    
    public class Triangle:Figure
    {
 
        public static int countOfSides()
        {
            return 3;
        }

        public Side sideA { get; set; }
        public Side sideB { get; set; }
        public Side sideC { get; set; }

 
        public override double Perimeter()
        {
            return (sideA.Length() + sideB.Length() + sideC.Length());
        }
        public override double Square()
        {
            double semiPerimetr = this.Perimeter()/2;
            return (Math.Sqrt(semiPerimetr*(semiPerimetr-sideA.Length())*(semiPerimetr - sideB.Length()) *(semiPerimetr - sideC.Length())));
        }

    }

    internal class CreateTriangle : Creator
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
