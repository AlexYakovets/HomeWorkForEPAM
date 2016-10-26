using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCDLibrary;

namespace UnitTestGCDAlgoritms
{
    [TestClass]
    public class UnitGCDAlgoritmsTests
    {
        [TestMethod]
        public void GCDByEuclide_GCDof775and225is75_75()
        {
            // arrange
            long dummy;
            int number1 = 750;
            int number2 = 225;
            // act
            int result = GCDAlgoritms.GCDByEuclide(number1,number2, out dummy);
            // assert
            Assert.AreEqual(75, result);
        }
        [TestMethod]
        public void GDCByStein_GCDof775and225is75_75()
        {
            // arrange
            long dummy;
            int number1 = 750;
            int number2 = 225;
            // act
            int result = GCDAlgoritms.GCDByStein(number1, number2, out dummy);
            // assert
            Assert.AreEqual(75, result);
        }
    }
}
