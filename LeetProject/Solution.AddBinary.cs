namespace LeetProject;

/// <summary>
/// https://leetcode.com/problems/add-two-numbers/
/// </summary>
public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int getValue(ListNode node) { return node is null ? 0 : node.val; }
        ListNode stepToNext(ListNode? node) { return node is not null ? node.next : node; }
        var currentLn = new ListNode();
        var first = currentLn;
        var carry = 0;
        while (l1 != null || l2 != null || carry > 0)
        {
            var currentValue = getValue(l1) + getValue(l2) + carry;
            carry = currentValue / 10;
            currentValue = currentValue % 10;
            currentLn.val = currentValue;
            l1 = stepToNext(l1);
            l2 = stepToNext(l2);

            if ((l1 is not null || l2 is not null || carry > 0))
            {
                var newNode = new ListNode();
                currentLn.next = newNode;
                currentLn = currentLn.next;
            }
        }
        return first;
    }

    [Theory]
    [MemberData(nameof(AddTwoNumbersData))]
    public void AddTwoNumbersTest(int[] one, int[] two, int[] expected)
    {
        var lnOne = ListNode.ToListNode(one);
        var lnTwo = ListNode.ToListNode(two);
        var lnExpected = ListNode.ToListNode(expected);

        var result = AddTwoNumbers(lnOne, lnTwo);
        result.Should().BeEquivalentTo(lnExpected);
    }

    public static IEnumerable<object[]> AddTwoNumbersData =>
        new List<object[]>
        {
            new object[] { new[] { 0 }, new[] { 0 }, new[] { 0 } },
            new object[] { new[] { 1 }, new[] { 1 }, new[] { 2 } },
            new object[] { new[] { 1,1 }, new[] { 1,2 }, new[] { 2,3 } },
            new object[] { new[] { 1,1 }, new[] { 1 }, new[] { 2,1 } },
            new object[] { new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 } },
            new object[] { new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 } },
        };
}