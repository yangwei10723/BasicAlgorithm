using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBasicAlgorithmCSharp
{
    public class XLinkedLinerTable<T>
    {
        private int _count;
        private XLinkedNode<T> _head;
        private XLinkedNode<T> _tail;

        public int Count()
        {
            return _count;
        }

        public bool InsertNode(int index, XLinkedNode<T> node)
        {
            return false;
        }

        public bool DeleteNode(int index)
        {
            return false;
        }
    }

    public class XLinkedNode<T>
    {
        public T value;
        public XLinkedNode<T> next;
        public XLinkedNode<T> prev;
    }
}
