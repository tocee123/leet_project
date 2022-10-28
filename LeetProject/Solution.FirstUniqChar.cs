namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("aabb", -1)]
        public void FirstUniqCharTest(string input, int expected)
        {
            FirstUniqChar(input).Should().Be(expected);
        }

        public int FirstUniqChar(string s)
        {
            var dictionary = new Dictionary<char, List<int>>();
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (!dictionary.ContainsKey(c))
                {
                    dictionary[c] = new List<int>();
                }
                dictionary[c].Add(i);
            }
            return dictionary.FirstOrDefault(kvp => kvp.Value.Count == 1).Value?[0] ?? -1;
        }
    }
}
