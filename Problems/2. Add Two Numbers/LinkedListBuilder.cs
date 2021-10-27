namespace csharp
{
    internal class LinkedListBuilder
    {
        internal ListNode Build(int [] values)
        {
            ListNode prev = null;
            for (int i = values.Length - 1; i >= 0; i--)
            {
                var node = new ListNode(values[i]) {next = prev};
                prev = node;
            }

            return prev;
        }
    }
}