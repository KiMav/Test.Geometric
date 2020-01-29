using System.ComponentModel;
using Test.Geometric.Extensions;

namespace Test.Geometric.GeometricModels
{
    [ImmutableObject(true)]
    public class Circle 
    {
        public Circle(Point2D center, double radius)
        {
            radius.ThrowIfNotNumber();
            radius.ThrowIfArgumentNegative();

            Center = center;
            Radius = radius;
        }

        public readonly Point2D Center;
        public readonly double Radius;
    }
}
