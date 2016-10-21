using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using static StringRegex.StringRegexConvert;

namespace UnitTestStringRegex
{
    [TestClass]
    public class StringRegexTests
    {
        [TestMethod]
        public void IsMatch_HelloWorldMatchWorld_true()
        {
            // arrange
            string str = "Hello, World";
            string str_pattern = "World";
            // act
            bool result=IsMatchPattern(ref str, str_pattern);
            // assert
            Assert.AreEqual(true,result);
        }
        [TestMethod]
        public void SelectString_abc123SelectNumbers_123()
        {
            // arrange
            string str = "abc123";
            string str_pattern = @"\d+";
            // act
            SelectString(ref str,str_pattern);
            // assert
            Assert.AreEqual("123", str);

        }
    }
}
