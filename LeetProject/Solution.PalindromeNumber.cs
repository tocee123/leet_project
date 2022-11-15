namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(0, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(100, false)]
        [InlineData(1000000001, true)]
        public void IsPalindromeTests(int input, bool expected)
        {
            IsPalindrome4(input).Should().Be(expected);
        }

        public bool IsPalindrome(int x)
        {
            return x > 0 && x.ToString().Equals(string.Join("", x.ToString().Reverse()));
        }

        public bool IsPalindrome2(int x)
        {
            if (x < 0)
                return false;
            var newNumber = 0;
            var numberToCheck = x;

            while (true)
            {
                newNumber += x % 10;
                x /= 10;
                if (x == 0)
                    break;
                newNumber *= 10;
            }
            return newNumber == numberToCheck;
        }

        public bool IsPalindrome3(int x)
        {
            if (x < 0 || x % 10 == 0 && x != 0)
                return false;
            var numberToCheck = 0;
            while (x > numberToCheck)
            {
                numberToCheck = numberToCheck * 10 + x % 10;
                x /= 10;
            }
            return numberToCheck == x || x == numberToCheck / 10;
        }

        public bool IsPalindrome4(int x)
        {
            if (x < 0)
                return false;
            int original = x, rev = 0;
            while (x > 0)
            {
                rev = x % 10 + rev * 10;
                x /= 10;
            }
            return rev == original;
        }
    }
}
