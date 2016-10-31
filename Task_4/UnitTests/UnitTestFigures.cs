using System;
using System.Runtime.CompilerServices;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestFigures
    {
        public Triangle CreateTriangleForTest()
        {
            Side a = new Side(new Figures.Point(10, 10), new Figures.Point(40, 10));
            Side b = new Side(new Figures.Point(40, 10), new Figures.Point(10, 50));
            Side c = new Side(new Figures.Point(10, 50), new Figures.Point(10, 10));
            Figures.CreateTriangle triangleCreator= new  CreateTriangle();
            Triangle triangle = (Triangle) triangleCreator.Create(a, b, c);
            return triangle;

        }

        [TestMethod]
        public void TrianglePerimetr()
        {
            // arrange
            Triangle testTriangle=CreateTriangleForTest();          
            // act
            double perimetr = testTriangle.Perimeter();
            // assert
            Assert.AreEqual((double)120, perimetr);
        }
        [TestMethod]
        public void TriangleSquare()
        {
            // arrange
            Triangle testTriangle = CreateTriangleForTest();
            // act
            double square = testTriangle.Square();
            // assert
            Assert.AreEqual((double)600, square);
        }

    }
}
