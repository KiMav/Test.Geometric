using System;
using Test.Geometric.Resources;

namespace Test.Geometric.Exceptions
{
    public class ArgumentNotNumberException : ArgumentException
    {
        public ArgumentNotNumberException() :
            base($"{TextResources.ArgumentNotNumberExceptionText}")
        {
        }
    }
}
