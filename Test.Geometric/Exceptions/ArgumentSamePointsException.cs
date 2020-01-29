using System;
using Test.Geometric.Resources;

namespace Test.Geometric.Exceptions
{
    public class ArgumentSamePointsException : ArgumentException
    {
        public ArgumentSamePointsException() :
            base($"{TextResources.ArgumentSamePointsExceptionText}")
        {
        }
    }
}