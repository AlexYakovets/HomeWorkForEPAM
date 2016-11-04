using System;
using ClassLibrary1.Point;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTests
{
    [TestClass]
    public class ClassLibrarysTest
    {
        [TestMethod]
        public void PointComparer_Equals_true()
        {
            // arrange
            ClassLibrary1.Point.Point p1 =new Point(2,3);
            ClassLibrary1.Point.Point p2 = new Point(2, 3);
            // act
            ClassLibrary1.Point.PointEqualityComparer equalityComparer = new PointEqualityComparer();
            bool isEquals=equalityComparer.Equals(p1, p2);
            // assert
            Assert.AreEqual(true,isEquals);
        }

        [TestMethod]
        public void VectorOperationPlus()
        {
                // arrange
                Vector v1 = new Vector(new Point(1,1), new Point(2,4));
                Vector v2 = new Vector(new Point(2,4), new Point(5,6));
                // act
                Vector resultVector = v1 + v2;
            // assert
                Vector mock = new Vector(new Point(3, 5), new Point(7, 10));
                Assert.AreEqual(resultVector, mock);
            }

        }
    }

