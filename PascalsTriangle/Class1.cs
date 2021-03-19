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
                   .AsEnumerable(),fold);
                
            // return rows switch
            // {
            //     0 => new uint[0],
            //     1 => new[] {rows},
            //     2 => new uint[] {1, 1, 1},
            //     _ => new uint[0]
            // };
            
        }

        private static IEnumerable<uint> fold(IEnumerable<uint> accumulator, int current)
        {
            return accumulator;
        }
    }
}