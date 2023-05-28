namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void KWeakestRowsTests(int[][] mat, int k, int[] expected)
        {
            foreach (var item in KWeakestRows(mat, k))
            {
                _output.WriteLine(item.ToString());
            }

            KWeakestRows(mat, k).Should().BeEquivalentTo(expected);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[][]{ new[] {1,1,0,0,0}, new[] { 1, 1, 1, 1, 0 }, new[] { 1, 0, 0, 0, 0 } , new[] { 1, 1, 0, 0, 0 }, new[] { 1, 1, 1, 1, 1 } }, 3, new[] { 2, 0, 3 } },
            new object[] { new int[][]{ new[] { 1, 0, 0, 0 }, new[] { 1, 1, 1, 1 }, new[] { 1, 0, 0, 0 } , new[] { 1, 0, 0, 0 } }, 4, new[] { 0, 2, 3, 1 } }
        };



        public int[] KWeakestRows(int[][] mat, int k)
        => mat.Select((i, m)=>new { index = m, sum = i.Sum() })
                .OrderBy(x=> x.sum)
                .ThenByDescending(x=>x.index)
                .Take(k)
                .Select(x=>x.index)
                .ToArray();
    }
}
