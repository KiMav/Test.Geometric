using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Geometric.Exceptions;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.UnitTests
{
    [TestClass]
    public class CircleCalculation_GetArea_Test
    {
        [TestMethod]
        public void CircleCalculator_GetArea_Test()
        {
            var radius = 10.5d;
            var circle = new Circle(Point2D.ZeroPoint, radius);

            var calculator = CalculatorFactory.ProduceCircleCalculator();
            var circleArea = calculator.GetArea(circle);

            var s = Math.PI * radius * radius;
            Assert.AreEqual(s, circleArea, TestSettings.Delta);
        }

        [TestMethod]
        public void CircleCalculator_GetArea_Exception_Test()
        {
            var radius = double.MaxValue;
            var circle = new Circle(Point2D.ZeroPoint, radius);

            var calculator = CalculatorFactory.ProduceCircleCalculator();

            Assert.ThrowsException<CalculateAreaException>(() => calculator.GetArea(circle));
        }
    }
}
