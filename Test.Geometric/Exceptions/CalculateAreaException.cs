using System;
using Test.Geometric.Resources;

namespace Test.Geometric.Exceptions
{
    public class CalculateAreaException : Exception
    {
        public CalculateAreaException(Exception innerException) :
            base(TextResources.AreaCalculateExceptionText, innerException)
        {

        }
    }
}
