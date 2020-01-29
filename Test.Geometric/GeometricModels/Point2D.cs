using System;
using System.ComponentModel;
using Test.Geometric.Extensions;

namespace Test.Geometric.GeometricModels
{
    [ImmutableObject(true)]
    public class Point2D
    {
        public Point2D(double x, double y)
        {
            x.ThrowIfNotNumber();
            y.ThrowIfNotNumber();

            X = x;
            Y = y;
        }

        public readonly double X;
        public readonly double Y;
        public static readonly Point2D ZeroPoint = new Point2D(0, 0);

        public static bool operator ==(Point2D point1, Point2D point2)
        {
            if (Equals(point1, null) || Equals(point2, null))
                return false;

            if (ReferenceEquals(point1, point2))
                return true;

            return Math.Abs(point1.X - point2.X) < Settings.Delta && Math.Abs(point1.Y - point2.Y) < Settings.Delta;
        }

        public static bool operator !=(Point2D point1, Point2D point2)
        {
            return !(point1 == point2);
        }
    }
}
