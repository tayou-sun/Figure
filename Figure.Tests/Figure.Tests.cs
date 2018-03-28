using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figure.Tests
{
    [TestClass]

    public class CircleTests
    {
        [TestMethod]
        public void GetArea_Radius1_3_14returned()
        {
            var r = 1;
            var expected = 3.14;

            var shape = new Circle(r);
            var actual = shape.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_5And8And6_14_9returned()
        {
            var a = 5;
            var b = 8;
            var c = 6;
            var expected = 14.981238266578634;

            var shape = new Triangle(5, 8, 6);
            var actual = shape.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRight_5And8And6_Falsereturned()
        {
            var a = 5;
            var b = 8;
            var c = 6;
            var expected = false;

            var shape = new Triangle(5, 8, 6);
            var actual = shape.IsRight();

            Assert.AreEqual(expected, actual);
        }
    }
}
        

