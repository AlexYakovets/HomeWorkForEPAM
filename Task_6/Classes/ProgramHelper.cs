using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class ProgramHelper:ProgramConverter,Interfaces.ICodeChecker
    {
        //commented, because this metods derived from ProgramConverter
        //public string ConvertToCSharp(string str)
        //{
        //    str.Replace("VB", "C#");
        //    return str;
        //}

        //public string ConvertToVB(string str)
        //{
        //    str.Replace("C#", "VB");
        //    return str;
        //}

        public bool CodeCheckSyntax(string str, string lanquage)
        {
            return str.Contains(lanquage);
        }
    }
}
