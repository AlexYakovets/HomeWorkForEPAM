using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ProgramConverter:Interfaces.IConvertible
    {
        public string ConvertToCSharp(string str)
        {
            str.Replace("VB", "C#");
            return str;
        }

        public string ConvertToVB(string str)
        {
            str.Replace("C#", "VB");
            return str;
        }

    }
}
