using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PFunction.Tests
{
    [TestClass]
    public class PFunctionTests
    {
        [TestMethod]
        public void Area_5_78returned()
        {
            //arrange
            double r = 5;
            double expected = 78.5398;

            //act
            Circle circle = new Circle(r);
            double actual = Math.Round(circle.Area(), 4);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_6_8_10returned()
        {
            //arrange
            double a = 6;
            double b = 8;
            double c = 10;
            double expected = 24;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = Math.Round(triangle.Area(), 4);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
