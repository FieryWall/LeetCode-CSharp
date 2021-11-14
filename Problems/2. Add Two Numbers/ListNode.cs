using System.Collections;
using System.Collections.Generic;

namespace csharp.Problems._2._Add_Two_Numbers
{
    internal class ListNode : IEnumerable
    {
        internal int val;
        internal ListNode next;

        internal ListNode(int val)
        {
            this.val = val;
        }

        public IEnumerator GetEnumerator()
        {
            return new ListNodeEnumerator(this);
        }
    }

    internal class ListNodeEnumerator : IEnumerator<int>
    {
        private ListNode _current;

        public ListNodeEnumerator(ListNode root)
        {
            _current = root;
        }

        public bool MoveNext()
        {
            _current = _current.next;
            return _current != null;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public int Current => _current.val;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _current = null;
        }
    }
}