namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        public void LengthOfLastWordTests(string input, int expected)
        {
            LengthOfLastWord(input).Should().Be(expected);
        }

        public int LengthOfLastWord(string s)
        {
            return s.Trim().Split(" ").Where(w=>w.Length > 0).Last().Length;
        }
    }
}
