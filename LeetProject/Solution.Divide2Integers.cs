namespace LeetProject
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public partial class Solution
    {
        [Theory]
        [InlineData(-1, -1, 1)]
        [InlineData(-1, 1, -1)]
        [InlineData(7, 3, 2)]
        [InlineData(7, -3, -2)]
        [InlineData(10, 3, 3)]
        [InlineData(0, 1, 0)]
        [InlineData(1, 1, 1)]
        public void DivideTests(int dividend, int divisor, int expected)
        {
            Divide(dividend, divisor).Should().Be(expected);
        }

        public int Divide(int dividend, int divisor)
        {
            var negativeMultiply = ((dividend < 0 || divisor < 0) && !(dividend < 0 && divisor < 0)) ? -1 : 1;

            dividend = Cehck(dividend);
            divisor = Cehck(divisor);

            if (dividend == divisor)
                return 1 * negativeMultiply;

            var i = 0;
            while (true)
            {
                dividend -= divisor;
                if (dividend <= 0)
                    break;
                i++;
            }

            return i * negativeMultiply;
        }

        private int Cehck(int i)
        {
            if (i == int.MinValue)
                return int.MinValue + 1;
            return i < 0 ? i * -1 : i;

        }

        [Fact]
        public void Divide2LargNumbers()
        {
            var dividend = -2147483648;
            var divisor = -1;

            Divide(dividend, divisor).Should().BeGreaterThan(0);
        }
    }
}
