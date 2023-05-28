namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData("abccbaacz", 'c')]
        [InlineData("abcdd", 'd')]
        public void RepeatedCharacterTests(string input, char expected)
        {
            RepeatedCharacter(input).Should().Be(expected);
        }


        public char RepeatedCharacter(string s)
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
            var letterAndSecondPosition = dictionary.Where(kvp => kvp.Value.Count > 1)
                .Select(kvp => new { Letter = kvp.Key, SecondLetterPosition = kvp.Value[1] });
            return letterAndSecondPosition.First(kvp => kvp.SecondLetterPosition == letterAndSecondPosition.Min(m => m.SecondLetterPosition)).Letter;
        }
    }
}
