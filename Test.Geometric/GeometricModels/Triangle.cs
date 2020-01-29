using System.ComponentModel;
using Test.Geometric.Exceptions;

namespace Test.Geometric.GeometricModels
{
    [ImmutableObject(true)]
    public class Triangle 
    {
        public Triangle(Point2D point1, Point2D point2, Point2D point3)
        {
            if (point1 == point2 || point2 == point3 || point3 == point1)
                throw new ArgumentSamePointsException();

            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public readonly Point2D Point1;
        public readonly Point2D Point2;
        public readonly Point2D Point3;
    }
}
