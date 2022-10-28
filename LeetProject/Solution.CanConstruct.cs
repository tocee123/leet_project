namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        public void CanConstructTest(string ransomNote, string magazine, bool expected)
        {
            CanConstruct(ransomNote, magazine).Should().Be(expected);
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            var ransomNoteLetters = ransomNote.ToCharArray().ToList();
            var magazineLetters = magazine.ToCharArray();

            foreach (var item in magazineLetters)
            {
                if (ransomNoteLetters.Contains(item))
                {
                    ransomNoteLetters.Remove(item);
                }
            }

            return ransomNoteLetters.Count == 0;
        }
    }
}
