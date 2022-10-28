namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(new[] { "Mary", "John", "Emma" }, new[] { 180, 165, 170 }, new[] { "Mary", "Emma", "John" })]
        [InlineData(new[] { "Alice", "Bob", "Bob" }, new[] { 155, 185, 150 }, new[] { "Bob", "Alice", "Bob" })]
        public void SortPeopleTests(string[] names, int[] heights, string[] expected)
        {
            SortPeople(names, heights).Should().Equal(expected);
        }

        public string[] SortPeople(string[] names, int[] heights)
        {
            var merged = new List<(string name, int height)>();
            for (int i = 0; i < names.Length; i++)
            {
                merged.Add((names[i], heights[i]));
            }

            return merged.OrderByDescending(x => x.height).Select(x => x.name).ToArray();
        }
    }
}
