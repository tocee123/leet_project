namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "dog", "dog", "dog" }, "dog")]
        public void LongestCommonPrefix_Tests(string[] input, string expected)
        {
            LongestCommonPrefix1(input).Should().Be(expected);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            string longestCommonPrefix = "";
            var i = 1;
            while (longestCommonPrefix != strs.First())
            {
                var commonPrefix = strs.First()[..i];
                if (!strs.All(x => x.StartsWith(commonPrefix)))
                {
                    break;
                }
                i++;
                longestCommonPrefix = commonPrefix;
            }
            return longestCommonPrefix;
        }

        public string LongestCommonPrefix1(string[] strs)
        {
            var minimum = strs.First().Length;

            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;
                while (j < strs[i].Length && strs[i][j] == strs[0][j])
                    j++;
                minimum = Math.Min(minimum, j);
            }

            return strs.First()[..minimum];
        }
    }
}
