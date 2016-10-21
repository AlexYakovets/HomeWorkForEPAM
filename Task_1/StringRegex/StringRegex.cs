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
    /// <summary>
    ///  class StringRegexConvert
    ///  main class of the dll "StringRegex"
    ///  working with xml-comments
    /// </summary>
    public static class StringRegexConvert
    {
        /// <summary>
        /// The method "IsMatchPattern" check input string for pattern matching
        /// </summary>
        /// <param name="_str">reference to input string</param>
        /// <param name="_verifypattern">pattern,which string should correspond</param>
        public static bool IsMatchPattern(ref string _str, string _verifypattern)
        {
            if (String.IsNullOrEmpty(_str)) throw new ArgumentException("string dosn't be empty or has null reference");
            Regex reg = new Regex(_verifypattern);
            return (reg.IsMatch(_str));
        }
        /// <summary>
        /// The method "SelectString" check input string for pattern matching
        /// </summary>
        /// <param name="_str">reference to variable string</param>
        /// <param name="_pattern">pattern,thanks to, line should be changed</param>
        public static void SelectString(ref string _str, string _pattern)
        {
            if (String.IsNullOrEmpty(_str)) throw new ArgumentException("string dosn't be empty or has null reference");
            Regex reg = new Regex(_pattern);
            Match matches = reg.Match(_str);
            _str = matches.Value;
        }
        /// <summary>
        /// The method "DoReplace" making changes in the line
        /// </summary>
        /// <param name="_str">reference to variable string</param>
        /// <returns>edited string</returns>
        public static void DoReplace(ref string _str)
        {
            if (String.IsNullOrEmpty(_str)) throw new ArgumentException("string dosn't be empty or has null reference");
            _str = Regex.Replace(_str, @",", " Y:");
            _str = Regex.Replace(_str, @"\[0-9].[0-9]", ",");
            _str = Regex.Replace(_str, "^", "X:");
        }
        /// <summary>
        /// The method "DoReplace" making changes in all lines of the file 
        /// </summary>
        /// <param name="_fileName">path to the file</param>
        /// <returns>List of strings,which changed if it matching pattern</returns>
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
                        if (IsMatchPattern(ref str, @"\b[0-9]{2}[.][0-9]{4}[,][0-9]{2}[.][0-9]{4}\b"))
                        {
                            str = Regex.Replace(str, @",", " Y:");
                            str = Regex.Replace(str, @"\[0-9].[0-9]", ",");
                            str = Regex.Replace(str, "^", "X:");
                            returnedStrings.Add(str);
                        }
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
