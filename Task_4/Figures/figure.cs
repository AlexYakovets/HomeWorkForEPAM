using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Figure
    {
        public abstract double Perimeter();
        public abstract double Square();
    }

    internal abstract class Creator
    {
        public abstract Figure Create();
        public abstract Figure Create(Side a,Side b,Side c);
    }
}
