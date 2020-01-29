using System.Runtime.CompilerServices;
using Test.Geometric.Exceptions;

namespace Test.Geometric.Extensions
{
    internal static class DoubleExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfOverflow(this double value)
        {
            if (double.IsInfinity(value)) 
                throw new ArithmeticOverflowException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfArgumentNegative(this double value)
        {
            if (value < 0) 
                throw new ArgumentNegativeNumberException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfNotNumber(this double value)
        {
            if (!double.IsFinite(value))
                throw new ArgumentNotNumberException();
        }
    }
}
