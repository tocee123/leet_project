namespace LeetProject
{
    public partial class Solution
    {
        [Fact]
        public void ListNodeTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(1);

            var result = true;
            while (linkedList.Count > 0)
            {
                result = linkedList.First.Value == linkedList.Last.Value;
                if (!result)
                {
                    break;
                }
                linkedList.RemoveFirst();
                if (linkedList.Count != 0)
                {
                    linkedList.RemoveLast();
                }
            }

            result.Should().BeTrue();
        }

        ListNode GetLast(ListNode head, ListNode last = null)
        {
            while (head.next != last)
            {
                head = head.next;
            }
            return head;
        }

        [Fact]
        public void WriteOut()
        {
            var head = new ListNode(1);
            head = new ListNode(2, head);
            head = new ListNode(3, head);
            head = new ListNode(4, head);

            var result = true;
            var loop = head;

            //while (loop != null)
            //{
            //    output.WriteLine(loop.val.ToString());
            //    loop = loop.next;
            //}

            var last = GetLast(head, null);

            while (true)
            {
                _output.WriteLine(last.val.ToString());
                last = GetLast(head, last);
                if (last == head)
                {
                    _output.WriteLine(last.val.ToString());
                    break;
                }
            }


            //var lastPrevious = head;
            //while (last != head)
            //{

            //}


        }
        [Fact]
        public void Test1()
        {
            var head = new ListNode(1);
            head = new ListNode(2, head);
            head = new ListNode(2, head);
            head = new ListNode(1, head);

            var result = true;

            var last = head;

            while (last.next != null)
            {
                last = last.next;
            }

            while (head.next != null)
            {
                //get lastPrevious

                var lastPrevious = head;

                while (lastPrevious.next != last)
                {
                    lastPrevious = lastPrevious.next;
                }
                result = head.val == last.val;
                if (!result)
                    break;
                head = head.next;
                last = lastPrevious;
            }

            result.Should().BeTrue();
        }

        public bool IsPalindrome(ListNode head)
        {
            //var result = true;
            //var first = head.First;
            //var last = head.Last;

            //while (first != last)
            //{
            //    result = first.Value == last.Value;
            //    if (!result)
            //    {
            //        break;
            //    }
            //    first = first.Next;
            //    last = last.Previous;
            //}
            //return result;

            return true;
        }
    }
}
