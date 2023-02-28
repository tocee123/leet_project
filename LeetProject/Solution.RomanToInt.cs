namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("XV", 15)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("XXVII", 27)]
        [InlineData("XLIX", 49)]
        public void RomanToIntTests(string s, int expected)
        {
            RomanToInt2(s).Should().Be(expected);
        }
        public int RomanToInt2(string s)
        {
            var dic = new Dictionary<char, int>
            {
                ['M'] = 1000,
                ['D'] = 500,
                ['C'] = 100,
                ['L'] = 50,
                ['X'] = 10,
                ['V'] = 5,
                ['I'] = 1
            };

            return s.Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC")
                .ToCharArray().Sum(c => dic[c]);
        }

        public int RomanToInt(string s)
        {
            var dic = new Dictionary<string, int>
            {
                ["M"] = 1000,
                ["CM"] = 900,
                ["D"] = 500,
                ["CD"] = 400,
                ["C"] = 100,
                ["XC"] = 90,
                ["L"] = 50,
                ["XL"] = 40,
                ["X"] = 10,
                ["IX"] = 9,
                ["V"] = 5,
                ["IV"] = 4,
                ["I"] = 1
            };

            var romanList = s.ToCharArray().Select(s => s.ToString()).ToList();

            var result = 0;

            for (int i = 0; i < romanList.Count; i++)
            {
                if (i<romanList.Count-1 && dic[romanList[i]] < dic[romanList[i + 1]])
                {
                    result += dic[$"{romanList[i]}{romanList[i+1]}"];
                    i++;
                }
                else
                {
                    result += dic[romanList[i]];
                }
            }
            return result;
        }
    }
}
