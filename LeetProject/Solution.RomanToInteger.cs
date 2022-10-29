namespace LeetProject
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public partial class Solution
    {
        [Theory]
        [InlineData("(", false)]
        [InlineData(")", false)]
        [InlineData("(abc)", true)]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(asdk)[weq]{dcad}", true)]

        [InlineData("asdbe(sadnj(asdfnkdf){kjsfmk}[asdk][asda[asdas]]as32d)", true)]
        [InlineData("(}", false)]
        public void ValidParenthesesTests(string input, bool expected)
        {
            ValidParentheses(input).Should().Be(expected);
        }

        public bool ValidParentheses(string s)
        {
            var isValid = true;
            var parentheses = "([{)]}";

            var checking = new Stack<char>();
            foreach (var item in s.ToCharArray().Where(x=>parentheses.Contains(x)))
            {
                if (parentheses[..3].Contains(item))
                    checking.Push(item);
                if (parentheses[3..].Contains(item))
                {
                    if (checking.Count == 0 || checking.TryPop(out var latest) && parentheses[..3][parentheses[3..].IndexOf(item)] != latest)
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            return isValid && checking.Count == 0;
        }
    }
}
