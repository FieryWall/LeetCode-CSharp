namespace csharp
{
    internal class AddTwoNumbersSolution {
        internal ListNode AddTwoNumbers(ListNode l1, ListNode l2, ListNode r = null, int c = 0) 
        {
            if (l1 == null && l2 == null && c == 0) return l1;
            var s = (l1?.val ?? 0) + (l2?.val ?? 0) + c;
            c = s / 10;
            r = l1 ?? l2 ?? new ListNode(0);
            r.val = s % 10;
            r.next = AddTwoNumbers(l1?.next, l2?.next, r, c);
            return r;
        }
    }
}