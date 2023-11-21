using System.Diagnostics;

namespace LeetProject.Models;

[DebuggerDisplay("{val}, {next}")]
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode ToListNode(int[] input)
    {
        var listNode = new ListNode(input[0]);
        var currentLn = listNode;
        for (int i = 1; i < input.Length; i++)
        {
            var ln = new ListNode(input[i]);
            currentLn.next = ln;
            currentLn = currentLn.next;
        }
        return listNode;
    }
}