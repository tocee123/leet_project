using System.Text;

namespace LeetProject
{
    public partial class Solution
    {
        [Theory]
        [InlineData("leet", "DDR!UURRR!!DDD!")]
        [InlineData("code", "RR!DDRR!UUL!R!")]
        [InlineData("zdz", "DDDDD!UUUUURRR!DDDDLLLD!")]
        public void AlphabetBoardPathTests(string input, string expected)
        {
            AlphabetBoardPath(input).Should().Be(expected);
        }

        public string AlphabetBoardPath1(string target)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();
            var mapping = alphabet.ToDictionary(c => c, c => (Array.IndexOf(alphabet, c) / 5, Array.IndexOf(alphabet, c) % 5));

            var result = new StringBuilder();

            int x0 = 0, y0 = 0;

            Action<string, int> append = (string direction, int movement) => result.Append(string.Join("", Enumerable.Repeat(direction, movement)));

            foreach (var c in target)
            {
                (var x, var y) = mapping[c];
                if (x < x0) append("U", x0 - x);
                if (y < y0) append("L", y0 - y);
                if (x > x0) append("D", x - x0);
                if (y > y0) append("R", y - y0);
                result.Append("!");
                x0 = x;
                y0 = y;
            }

            return result.ToString();
        }

        public string AlphabetBoardPath(string target)
        {
            var alphabet = new[] { "abcde", "fghij", "klmno", "pqrst", "uvwxy", "z" };
            var i = 0;
            var mapping = alphabet.Select(a => new { row = i++, letters = a.ToArray() })
                .SelectMany(a => a.letters.Select(x => new { letter = x, row = a.row, column = Array.IndexOf(a.letters, x) }))
                .ToDictionary(x => x.letter, x => new Point(x.row, x.column));

            var startingPoint = new Point(0, 0);
            var result = new StringBuilder();
            foreach (var item in target)
            {
                var coordinates = mapping[item];

                result.Append(startingPoint.GetPath(coordinates));
                startingPoint = coordinates with { };
            }

            return result.ToString();
        }

        private record Point(int Row, int Column)
        {
            public string GetPath(Point another)
            => $"{GetVerticalMovements(another)}{GetHorizontalMovements(another)}!";

            private string GetMovement(Point another, Func<Point, int> getValue, Func<int, string> getDirection)
            {
                var difference = getValue(this) - getValue(another);
                var horizontal = getDirection(difference);
                return Movements(horizontal, (difference));
            }

            private string GetHorizontalMovements(Point another)
                => GetMovement(another, p => p.Column, GetHorizontalDirection);

            private string GetVerticalMovements(Point another)
                => GetMovement(another, p => p.Row, GetVerticalDirection);

            private static string GetDirection(int movementCount, string positive, string negative)
               => movementCount < 0 ? positive : (movementCount > 0 ? negative : "");

            private static string GetHorizontalDirection(int movementCount)
                => GetDirection(movementCount, "R", "L");

            private static string GetVerticalDirection(int movementCount)
                => GetDirection(movementCount, "D", "U");

            private static string Movements(string direction, int count)
                => string.Join("", Enumerable.Repeat(direction, Math.Abs(count)));
        }
    }
}
