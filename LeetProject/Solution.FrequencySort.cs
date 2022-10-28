namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData("tree", "eert")]
        [InlineData("cccaaa", "aaaccc")]
        [InlineData("Aabb", "bbAa")]
        public void FrequencySortTest(string input, string expected)
        {
            FrequencySort(input).Should().Be(expected);
        }

        public string FrequencySort(string s)
        {
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (!dictionary.ContainsKey(c))
                {
                    dictionary[c] = 0;
                }
                dictionary[c] += 1;
            }
            return string.Join("", dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(kvp => "".PadLeft(kvp.Value, kvp.Key)));
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 2, 3 }, new[] { 3, 1, 1, 2, 2, 2 })]
        [InlineData(new[] { 2, 3, 1, 3, 2 }, new[] { 1, 3, 3, 2, 2 })]
        [InlineData(new[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, new[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 })]
        public void FrequencySortTests(int[] input, int[] expected)
        {
            FrequencySort(input).Should().Equal(expected);
        }

        public int[] FrequencySort(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = 0;
                }
                dictionary[nums[i]]++;
            }

            return dictionary
                .OrderBy(kvp => kvp.Value)
                .ThenByDescending(kvp => kvp.Key)
                .SelectMany(kvp => Enumerable.Repeat(kvp.Key, kvp.Value))
                .ToArray();
        }
    }
}
