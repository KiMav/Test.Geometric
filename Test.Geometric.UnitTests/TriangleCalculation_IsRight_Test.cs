using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Geometric.Exceptions;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.UnitTests
{
    [TestClass]
    public class TriangleCalculation_IsRight_Test
    {
        [TestMethod]
        public void TriangleCalculator_IsRight_Test()
        {
            var point1 = Point2D.ZeroPoint;
            var point2 = new Point2D(100, 100);
            var point3 = new Point2D(-100, 100);

            var triangle = new Triangle(point1, point2, point3);

            var calculator = CalculatorFactory.ProduceTriangleCalculator();
            var isRight = calculator.IsRightTriangle(triangle);

            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void TriangleCalculator_IsNotRight_Test()
        {
            var point1 = Point2D.ZeroPoint;
            var point2 = new Point2D(100, 100);
            var point3 = new Point2D(-100, -100);

            var triangle = new Triangle(point1, point2, point3);

            var calculator = CalculatorFactory.ProduceTriangleCalculator();
            var isRight = calculator.IsRightTriangle(triangle);

            Assert.IsFalse(isRight);
        }

        [TestMethod]
        public void TriangleCalculator_Exception_Test()
        {
            var point1 = Point2D.ZeroPoint;
            var point2 = new Point2D(double.MaxValue, double.MaxValue);
            var point3 = new Point2D(double.MinValue, double.MaxValue);

            var triangle = new Triangle(point1, point2, point3);

            var calculator = CalculatorFactory.ProduceTriangleCalculator();

            Assert.ThrowsException<CalculateAreaException>(() => calculator.IsRightTriangle(triangle));
        }
    }
}
