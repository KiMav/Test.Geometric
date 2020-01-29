using Test.Geometric.Calculators;

namespace Test.Geometric
{
    public static class CalculatorFactory
    {
        public static ITriangleCalculator ProduceTriangleCalculator()
        {
            return new TriangleCalculator();
        }

        public static ICircleCalculator ProduceCircleCalculator()
        {
            return new CircleCalculator();
        }
    }
}
