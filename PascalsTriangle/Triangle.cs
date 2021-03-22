using System.Collections.Generic;
using System.Linq;
using static LanguageExt.Prelude;

namespace PascalsTriangle
{
    public static class Triangle
    {
        public static IEnumerable<uint> DrawTriangle(uint rows) =>
            Enumerable
                .Range(0, (int) rows)
                .Aggregate(EmptyList, BuildTriangle);

        private static IEnumerable<uint> BuildTriangle(IEnumerable<uint> triangle, int currentRowNumber)
        {
            return (triangle is null, currentRowNumber) switch
            {
                (true, _) => triangle,
                (_, 0) => FirstRow,
                (_, 1) => SecondRow,
                (_, _) => BuildNextRow(triangle, currentRowNumber)
            };

            static IEnumerable<uint> BuildNextRow(IEnumerable<uint> triangle, int previousRowNumber) =>
                triangle
                    .TakeLast(previousRowNumber)
                    .Pairwise()
                    .Aggregate(triangle.Append(One), (accumulator, pair) => accumulator.Append(pair.Previous + pair.Current))
                    .Append(One);
        }

        private const uint One = 1;
        private static IEnumerable<uint> EmptyList => List<uint>().AsEnumerable();
        private static IEnumerable<uint> FirstRow => List(One);
        private static IEnumerable<uint> SecondRow => List<uint>(1, 1, 1);
    }
}