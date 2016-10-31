using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class ProgramHelper:Interfaces.IConvertible
    {
        public string ConvertToCSharp(string str)
        {
            return str;
        }

        public string ConvertToVB(string str)
        {
            return str;
        }
    }
}
