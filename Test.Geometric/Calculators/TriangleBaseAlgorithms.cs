using System;
using Test.Geometric.Extensions;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.Calculators
{
    internal static class TriangleBaseAlgorithms
    {
        public static double GetArea(double side1, double side2, double side3, double perimeter)
        {
            var coeficient1 = perimeter - side1;
            var coeficient2 = perimeter - side2;
            var coeficient3 = perimeter - side3;

            var coefficient = new[] { coeficient1, coeficient2, coeficient3, perimeter };
            Array.Sort(coefficient);

            var result = Math.Sqrt(coefficient[0] * coefficient[3] * coefficient[1] * coefficient[2]);
            result.ThrowIfOverflow();

            return result;
        }

        public static double GetPerimeter(double side1, double side2, double side3)
        {
            var result = side1 * 0.5d + side2 * 0.5d + side3 * 0.5d;
            result.ThrowIfOverflow();

            return result;
        }

        public static (double side1, double side2, double side3) GetSides(Point2D point1, Point2D point2, Point2D point3)
        {
            var side1 = point2.DistanceTo(point1);
            side1.ThrowIfOverflow();

            var side2 = point3.DistanceTo(point2);
            side2.ThrowIfOverflow();

            var side3 = point1.DistanceTo(point3);
            side3.ThrowIfOverflow();

            return (side1, side2, side3);
        }
    }
}
