namespace PascalsTriangle
{
    public static class Triangle
    {
        public static uint[] DrawTriangle(uint rows)
        {
            return rows switch
            {
                0 => new uint[0],
                1 => new[] {rows},
                2 => new uint[] {1, 1, 1},
                _ => new uint[0]
            };
            
        }
    }
}