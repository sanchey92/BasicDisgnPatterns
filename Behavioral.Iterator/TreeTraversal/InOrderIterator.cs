namespace Behavioral.Iterator.TreeTraversal
{
    public class InOrderIterator<T>
    {
        public Node<T> Current { get; set; }
        private readonly Node<T> _root;
        private bool _yieldedStart;

        public InOrderIterator(Node<T> root)
        {
            _root = Current = root;
            while (Current.Left != null)
            {
                Current = Current.Left;
            }
        }

        public void Reset()
        {
            Current = _root;
            _yieldedStart = true;
        }

        public bool MoveNext()
        {
            if (!_yieldedStart)
            {
                _yieldedStart = true;
                return true;
            }

            if (Current.Right != null)
            {
                Current = Current.Right;
                while (Current.Left != null)
                {
                    Current = Current.Left;
                }

                return true;
            }
            else
            {
                var p = Current.Parent;
                while (p != null && Current == p.Right)
                {
                    Current = p;
                    p = p.Parent;
                }

                Current = p;
                return Current != null;
            }
        }
    }
}