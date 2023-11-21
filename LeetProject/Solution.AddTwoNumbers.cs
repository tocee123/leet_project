namespace LeetProject;

/// <summary>
/// https://leetcode.com/problems/add-binary/description/
/// </summary>
public partial class Solution
{
    public string AddBinary(string l1, string l2)
    {
        return "";
    }

    [Theory]
    [MemberData(nameof(AddBinaryData))]
    public void AddBinaryTests(string one, string two, string expected)
    {
        var result = AddBinary(one, two);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> AddBinaryData =>
        new List<object[]>
        {
            new object[] { "11", "1", "100" },
        };
}