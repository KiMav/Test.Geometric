using Test.Geometric.GeometricModels;

namespace Test.Geometric
{
    public interface ITriangleCalculator 
    {
        double GetArea(Triangle triangle);
        bool IsRightTriangle(Triangle triangle);
    }
}
