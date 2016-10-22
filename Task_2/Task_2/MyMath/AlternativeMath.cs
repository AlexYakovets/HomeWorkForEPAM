using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class AlternativeMath
    {
        static public double SqrtByNewton(double n, double A, double eps)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
            }
            return x1;
        }
        public static string ToBinaryCode(int numeric)
        {
            if(numeric<0)throw new ArgumentOutOfRangeException();
            int temp1 = 0;
            List<int> s = new List<int>();
            while (numeric > 0)
            {
                temp1 = numeric % 2;
                numeric = numeric / 2;
                s.Add(temp1);
                //switch elements in list sides
            }
            string str = "";
                for (int i = s.Count - 1; i >= 0; i--)
                {
                str += Convert.ToString(s[i]);
                }
                return Convert.ToString(str);
            }
        }
    }

