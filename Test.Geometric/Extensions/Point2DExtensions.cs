using System;
using System.Runtime.CompilerServices;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.Extensions
{
    internal static class Point2DExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double DistanceTo(this Point2D fromPoint, Point2D toPoint)
        {
            var deltaX = toPoint.X - fromPoint.X;
            var deltaY = toPoint.Y - fromPoint.Y;

            var result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return result;
        }
    }
}
