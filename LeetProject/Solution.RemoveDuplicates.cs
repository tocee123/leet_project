namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [MemberData(nameof(RemoveDuplicatesTestsData))]
        public void RemoveDuplicatesTests(int[ ]input, int expected)
        {
            RemoveDuplicates(input).Should().Be(expected);
        }

        public int RemoveDuplicates(int[] nums)
        {
            return 0;
        }

        public static IEnumerable<object[]> RemoveDuplicatesTestsData =>
        new List<object[]>
        {
            new object[] { new[] { 1,1,2}, 2 },
        };
    }
}
