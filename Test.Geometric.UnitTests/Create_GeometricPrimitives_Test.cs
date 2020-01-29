using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Geometric.Exceptions;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.UnitTests
{
    [TestClass]
    public class Create_GeometricPrimitives_Test
    {
        [TestMethod]
        public void Create_Point2D_Exceptions()
        {
            Assert.ThrowsException<ArgumentNotNumberException>(() => new Point2D(double.NegativeInfinity, 0));
            Assert.ThrowsException<ArgumentNotNumberException>(() => new Point2D(double.PositiveInfinity, 0));
            Assert.ThrowsException<ArgumentNotNumberException>(() => new Point2D(double.NaN, 0));
        }

        [TestMethod]
        public void Create_Circle_Exceptions()
        {
            Assert.ThrowsException<ArgumentNotNumberException>(() => new Circle(Point2D.ZeroPoint, double.NegativeInfinity));
            Assert.ThrowsException<ArgumentNotNumberException>(() => new Circle(Point2D.ZeroPoint, double.PositiveInfinity));
            Assert.ThrowsException<ArgumentNotNumberException>(() => new Circle(Point2D.ZeroPoint, double.NaN));
            Assert.ThrowsException<ArgumentNegativeNumberException>(() => new Circle(Point2D.ZeroPoint, -100));
        }

        [TestMethod]
        public void Create_Triangle_Exceptions()
        {
            var certainPoint = new Point2D(100,100);
            var samePoint = new Point2D(certainPoint.X, certainPoint.Y);

            Assert.ThrowsException<ArgumentSamePointsException>(() => new Triangle(Point2D.ZeroPoint, certainPoint, samePoint));
            Assert.ThrowsException<ArgumentSamePointsException>(() => new Triangle(certainPoint, Point2D.ZeroPoint, samePoint));
            Assert.ThrowsException<ArgumentSamePointsException>(() => new Triangle(certainPoint, samePoint, Point2D.ZeroPoint));
        }
    }
}
