using System;
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
            if (currentRowNumber == 0)
                return new List<uint>(){ 1 };

            var previousRow = triangle.Take(currentRowNumber).ToArray();
            // var lastRowThing = triangle.IndexOf(triangle.Count() - 1) + 1
            //  = rowNumber - 1 
            //var newRow = new uint[] { 1, (previousRow[0] + previousRow[1]) + ... + 1
            var newRow = new List<uint>();
            newRow.Add(1);
            if (previousRow.Length >= 2)
            {
                for (uint i = 0; i < currentRowNumber - 1; i++)
                {
                    var newThing = previousRow[i] + previousRow[i+1];
                    newRow.Add(newThing);
                }
            }
            newRow.Add(1);

            var thingy = triangle.Concat(newRow);
            return thingy;

            // return rows switch
            // {
            //     0 => new uint[0],
            //     1 => new[] {rows},
            //     2 => new uint[] {1, 1, 1},
            //     _ => new uint[0]
            // };
        }
    }
}