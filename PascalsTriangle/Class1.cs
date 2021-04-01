using System.Collections.Generic;
using System.Linq;

namespace PascalsTriangle
{
    public static class Triangle
    {
        public static IEnumerable<uint> DrawTriangle(uint rows)
        {
           return Enumerable
               .Range(0, (int) rows)
               .Aggregate(new List<uint>()
                   .AsEnumerable(), fold);

        }

        private static IEnumerable<uint> fold(IEnumerable<uint> triangle, int currentRowNumber)
        {
            return currentRowNumber switch
            {
                0 => new List<uint> {1},
                1 => new List<uint> {1, 1, 1},
                _ => BuildTriangle(triangle, currentRowNumber)
            };
        }
        
        private static IEnumerable<uint> BuildTriangle(IEnumerable<uint> triangle, int currentRowNumber)
        {
            var previousRow = triangle.TakeLast(currentRowNumber).ToArray();
            
            List<uint> newRow = new List<uint> {1};
            for (uint i = 0; i < currentRowNumber - 1; i++)
            {
                newRow.Add(previousRow[i] + previousRow[i+1]);
            }
            newRow.Add(1);

            return triangle.Concat(newRow);
        }
    }
}