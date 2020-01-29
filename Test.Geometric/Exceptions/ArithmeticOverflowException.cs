using System;
using Test.Geometric.Resources;

namespace Test.Geometric.Exceptions
{
    public class ArithmeticOverflowException :  Exception
    {
        public ArithmeticOverflowException():
            base($"{TextResources.ArithmeticOverflowExceptionText}")
        {
        }
    }
}
