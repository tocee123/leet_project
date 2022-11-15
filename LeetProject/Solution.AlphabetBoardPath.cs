namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(14, 6)]
        [InlineData(8, 4)]
        [InlineData(123, 12)]
        public void NumberOfStepsTests(int number, int expected)
        {
            NumberOfSteps(number).Should().Be(expected);
        }

        public int NumberOfSteps(int num)
        {
            var stepsCount = 0;

            while (num > 0)
            {
                stepsCount++;
                num = num % 2 == 0 ? num / 2 : num - 1;
            }

            return stepsCount;
        }

        public int NumberOfSteps2(int num)
        {
            Dictionary<int, Func<int, int>> steps = new() { [0] = x => x / 2, [1] = x => x - 1 };
            var stepsCount = 0;

            while (num > 0)
            {
                stepsCount++;
                num = steps[num & 1](num);
            }

            return stepsCount;
        }

        public int NumberOfSteps1(int num)
        {
            var stepsCount = 0;

            while (num > 0)
            {
                stepsCount++;
                if (num % 2 == 0)
                    num /= 2;
                else
                    num -= 1;
            }

            return stepsCount;
        }
    }
}
