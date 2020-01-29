using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Geometric.Exceptions;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.UnitTests
{
    [TestClass]
    public class TriangleCalculation_GetArea_Test
    {
        [TestMethod]
        public void TriangleCalculator_GetArea_Test()
        {
            var point1 = Point2D.ZeroPoint;
            var point2 = new Point2D(35.5, 125.5);
            var point3 = new Point2D(-425.45, 4);

            var triangle = new Triangle(point1, point2, point3);

            var calculator = CalculatorFactory.ProduceTriangleCalculator();
            var triangleArea = calculator.GetArea(triangle);

            var s = CalculateTriangleAreaViaCoordinates(triangle);
            Assert.AreEqual(s, triangleArea, TestSettings.Delta);
        }

        private double CalculateTriangleAreaViaCoordinates(Triangle t)
        {
            var coefficient = 
                (t.Point1.X - t.Point3.X) * (t.Point2.Y - t.Point3.Y) -
                (t.Point2.X - t.Point3.X) * (t.Point1.Y - t.Point3.Y);

            var result = Math.Abs(coefficient * 0.5);

            return result;
        }

        [TestMethod]
        public void TriangleCalculator_GetArea_Exception_Test()
        {
            var point1 = Point2D.ZeroPoint;
            var point2 = new Point2D(double.MaxValue, double.MaxValue);
            var point3 = new Point2D(double.MaxValue, double.MinValue);

            var triangle = new Triangle(point1, point2, point3);

            var calculator = CalculatorFactory.ProduceTriangleCalculator();

            Assert.ThrowsException<CalculateAreaException>(() => calculator.GetArea(triangle));
        }
    }
}
