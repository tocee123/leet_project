namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [MemberData(nameof(RemoveDuplicatesTestsData))]
        public void RemoveDuplicatesTests(int[] input, int expected)
        {
            RemoveDuplicates(input).Should().Be(expected);
        }

        public int RemoveDuplicates(int[] nums)
        {
            var i = 0;
            while (i < nums.Length)
            {
                var itemToSearch = nums[i];
                i++;
            }

            return nums.Count();
        }

        public static IEnumerable<object[]> RemoveDuplicatesTestsData =>
        new List<object[]>
        {
            new object[] { new[] { 1,1,2}, 2 },
            new object[]{ new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5 }
        };
    }
}
