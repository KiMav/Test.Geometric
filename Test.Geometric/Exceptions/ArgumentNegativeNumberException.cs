using System;
using Test.Geometric.Resources;

namespace Test.Geometric.Exceptions
{
    public class ArgumentNegativeNumberException : ArgumentException
    {
        public ArgumentNegativeNumberException() :
            base($"{TextResources.ArgumentNegativeNumberExceptionText}")
        {
        }
    }
}