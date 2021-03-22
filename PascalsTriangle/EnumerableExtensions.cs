using System.Collections.Generic;
using MoreLinq;

namespace PascalsTriangle
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<(T Previous, T Current)> Pairwise<T>(this IEnumerable<T> source) 
            => source.Pairwise((previous, current) => (previous, current));
    }
}