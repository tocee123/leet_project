namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData(3, new[] { "1", "2", "Fizz" })]
        [InlineData(5, new[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void FizzBuzzTests(int range, IEnumerable<string> expected)
        {
            _output.WriteLine(range % 5 == 0 ? "Fizz" + (range % 5 == 0 ? "Buzz" : "") : range.ToString());

            FizzBuzz2(range).Should().BeEquivalentTo(expected);
        }

        public IList<string> FizzBuzz2(int n)
        {
            var result = Enumerable.Range(1, n)
                .Select(x => $"{(x % 3 == 0 ? "Fizz" : "")}{(x % 5 == 0 ? "Buzz" : "")}{(x % 5 != 0 && x % 3 != 0 ? x.ToString() : "")}")
                .ToList();

            return result;
        }

        public IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                var word = "";
                if (i % 3 == 0)
                {
                    word += "Fizz";
                }
                if (i % 5 == 0)
                {
                    word += "Buzz";
                }
                else if (string.IsNullOrEmpty(word))
                {
                    word += i.ToString();
                }
                result.Add(word);
            }
            return result;
        }
    }
}
