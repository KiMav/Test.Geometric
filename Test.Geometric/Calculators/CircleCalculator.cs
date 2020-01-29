using System;
using System.ComponentModel;
using Test.Geometric.Exceptions;
using Test.Geometric.Extensions;
using Test.Geometric.GeometricModels;

namespace Test.Geometric.Calculators
{
    [ImmutableObject(true)]
    internal class CircleCalculator : ICircleCalculator
    {
        public double GetArea(Circle circle)
        {
            try
            {
                var area = circle.Radius * circle.Radius * Math.PI;
                area.ThrowIfOverflow();

                return area;
            }
            catch (Exception e)
            {
                throw new CalculateAreaException(e);
            }
        }
    }
}
