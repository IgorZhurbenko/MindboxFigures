using MindboxFigures;
using NUnit.Framework;
using System;

namespace TestingProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckRightSideValues()
        {
            try
            {
                var triangle = new Triangle(1, 2, 3);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
            Assert.Fail();            
        }

        [Test]
        public void CalculateArea_ForSquareTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area);
        }

        [Test]
        public void CalculateArea_ForGeneralTriangle()
        {
            var triangle = new Triangle(13, 14, 22);
            Assert.IsTrue(85.999637f.ApproximatelyEqual(triangle.Area));
        }

        [Test]
        public void CalculateArea_ForCircle()
        {
            var circle = new Circle(13);
            Assert.IsTrue(530.92916f.ApproximatelyEqual(circle.Area));
        }
    }
}