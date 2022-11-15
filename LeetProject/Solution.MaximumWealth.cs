namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [MemberData(nameof(MaximumWealthTestsData))]
        public void MaximumWealthTests(int[][] input, int expected)
        {
            MaximumWealth(input).Should().Be(expected);
        }

        public static IEnumerable<object[]> MaximumWealthTestsData =>
        new List<object[]>
        {
            new object[] { new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } }, 6 },
            new object[] { new int[][] { new int[] { 1,5 }, new int[] { 7,3}, new int[] { 3,5} }, 10 },
            new object[] { new int[][] { new int[] { 2,8,7}, new int[] { 7,1,3}, new int[] { 1,9,5} }, 17 }
        };

        public int MaximumWealth(int[][] accounts)
        => accounts.Select(x => x.Sum()).Max();
    }
}
