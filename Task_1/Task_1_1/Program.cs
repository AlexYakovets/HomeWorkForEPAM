using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StringRegex;


namespace Task_1_1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "1.txt";
            string verifypattern = @"\b[0-9]{2}[.][0-9]{4}[,][0-9]{2}[.][0-9]{4}\b";
            Console.WriteLine("Input string, which need convert:");
            string str=Console.ReadLine();
            if (StringRegexConvert.IsMatchPattern(ref str, verifypattern))
            {
                StringRegexConvert.DoReplace(ref str);
                Console.WriteLine("Converted string: {0}", str);
            }
            Console.WriteLine("For start converting from file:{0}, press any key",fileName);
            Console.ReadKey();
            foreach (string s in StringRegexConvert.DoReplaceFromFile(fileName)) {
                Console.WriteLine(s);
            }
            Console.WriteLine("Please, press any key for closing window");
            Console.ReadKey();
        }
      
       
      
    }
}
