namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [MemberData(nameof(PlusOneTestsData))]
        public void PlusOneTests(int[] input, int[] expected)
        {
            PlusOne(input).Should().BeEquivalentTo(expected);
        }

        public int[] PlusOne(int[] digits)
        {
            //converting to list for easier manipulation
            var list = digits.ToList();
            //adding one to the last digit
            list[list.Count - 1] = list.Last() + 1;
            var lastIndex = list.Count - 1;
            //checking if the last digit exceeds 9
            while (list[lastIndex] > 9)
            {
                list[lastIndex] = 0;
                lastIndex--;
                //if we came to the 0th digit
                if (lastIndex < 0)
                {
                    //insert a new digit at the beginning and end cycle
                    list.Insert(lastIndex + 1, 1);
                    break;
                }
                else
                {
                    list[lastIndex]++;
                }
            }
            return list.ToArray();
        }

        public static IEnumerable<object[]> PlusOneTestsData =>
        new List<object[]>
        {
            new object[] { new[] { 1, 2, 3 }, new[] { 1, 2, 4 } },
            new object[] { new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 } },
            new object[] { new[] {1, 9 }, new[] { 2,0 } },
            new object[] { new[] { 9 }, new[] { 1,0 } },
        };
    }
}
