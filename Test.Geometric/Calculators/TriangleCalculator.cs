using System;
using Test.Geometric.Exceptions;
using Test.Geometric.Extensions;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.Calculators
{
    internal class TriangleCalculator : ITriangleCalculator
    {
        public double GetArea(Triangle triangle)
        {
            try
            {
                var (side1, side2, side3) = TriangleBaseAlgorithms.GetSides(triangle.Point1, triangle.Point2, triangle.Point3);
                var perimeter = TriangleBaseAlgorithms.GetPerimeter(side1, side2, side3);
                var area = TriangleBaseAlgorithms.GetArea(side1, side2, side3, perimeter);

                return area;
            }
            catch (Exception e)
            {
                throw new CalculateAreaException(e);
            }
        }

        public bool IsRightTriangle(Triangle triangle)
        {
            try
            {
                var (side1, side2, side3) = TriangleBaseAlgorithms.GetSides(triangle.Point1, triangle.Point2, triangle.Point3);

                var sides = new[] { side1, side2, side3 };
                Array.Sort(sides);

                var checkExpression = Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]);

                checkExpression.ThrowIfOverflow();

                var isRight = checkExpression <= Settings.Delta;

                return isRight;
            }
            catch (Exception e)
            {
                throw new CalculateAreaException(e);
            }
        }
    }
}
