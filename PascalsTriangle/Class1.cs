namespace PascalsTriangle
{
    public static class PascalsTriangle
    {
        public static uint[] DrawTriangle(uint rows)
        {
            return rows > 0 ?
                new[] {rows} : 
                new uint[0];
        }
    }
}