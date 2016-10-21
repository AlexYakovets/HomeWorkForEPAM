using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace StringRegex
{
    public static class StringRegexConvert
    {
        public static bool IsMatchPattern(ref string _str, string _verifypattern)
        {
            if (String.IsNullOrEmpty(_str)) throw new ArgumentException("string dosn't be empty or has null reference");
            Regex reg = new Regex(_verifypattern);
            return (reg.IsMatch(_str));
        }
        public static void SelectString(ref string _str, string _pattern)
        {
            if (String.IsNullOrEmpty(_str)) throw new ArgumentException("string dosn't be empty or has null reference");
            Regex reg = new Regex(_pattern);
            Match matches = reg.Match(_str);
            _str = matches.Value;
        }
        public static void DoReplace(ref string _str)
        {
            if (String.IsNullOrEmpty(_str)) throw new ArgumentException("string dosn't be empty or has null reference");
            _str = Regex.Replace(_str, @",", " Y:");
            _str = Regex.Replace(_str, @"\[0-9].[0-9]", ",");
            _str = Regex.Replace(_str, "^", "X:");
        }
        public static List<string> DoReplaceFromFile(string _fileName)
        {
            List<string> returnedStrings = new List<string> { };

            try
            {

                if (File.Exists(_fileName) == false)
                {
                    new FileNotFoundException();
                    returnedStrings.Add("File not found");
                }
                else
                {
                    string[] allText = File.ReadAllLines(_fileName);
                    String str;
                    foreach (string s in allText)
                    {
                        str = s;
                        str = Regex.Replace(str, @",", " Y:");
                        str = Regex.Replace(str, @"\[0-9].[0-9]", ",");
                        str = Regex.Replace(str, "^", "X:");
                        returnedStrings.Add(str);
                        //edit for commit
                    }

                }

            }
            catch (FileNotFoundException e)
            {
                returnedStrings.Add(e.Message);
            }
            return (returnedStrings);
        } 

    }
}
