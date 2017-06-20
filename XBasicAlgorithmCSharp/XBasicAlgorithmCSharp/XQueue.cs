using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBasicAlgorithmCSharp
{
    public enum XQueueIncreaseMode
    {
        PowerOfTwo,
        FixedSize,
    }

    public class XQueue<T>
    {
        private const int _minCapacity = 2;
        private XQueueIncreaseMode _mode;
        private int _capacity;
        private int _increaseFixedSize = 1;
        private T[] _arry;
        private int _head;
        private int _tail;
        private int _count;
        private int _itemSize;

        public XQueue(int itemSize, XQueueIncreaseMode mode, int increaseSize)
        {
            _itemSize = itemSize;
            _mode = mode;
            _increaseFixedSize = increaseSize;
            _capacity = _minCapacity;
            _arry = new T[_capacity];
        }

        public XQueue(int itemSize, int capacity, XQueueIncreaseMode mode, int increaseSize)
        {
            _itemSize = itemSize;
            _mode = mode;
            _increaseFixedSize = increaseSize;
            _capacity = capacity;
            _arry = new T[_capacity];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public int Count()
        {
            return _count;
        }

        public void EnQueue(T elem)
        {
            if (_count == _capacity)
            {
                if (_mode == XQueueIncreaseMode.FixedSize)
                {
                    _capacity += _increaseFixedSize;
                }
                else
                {
                    if (XCommonHelper.IsPowOfTwo(_capacity))
                    {
                        _capacity += _capacity;
                    }
                    else
                    {
                        _capacity = XCommonHelper.FindCeilPowOfTwo(_capacity);
                    }
                }
                T[] newArray = new T[_capacity];
                Buffer.BlockCopy(_arry, _head * _itemSize, newArray, 0, (_count - _head) * _itemSize);
                Buffer.BlockCopy(_arry, 0, newArray, (_count - _head) * _itemSize, _head * _itemSize);
                _arry = newArray;
                _head = 0;
                _tail = _count;
            }

            _arry[_tail] = elem;
            _count++;
            _tail++;
            _tail = _tail % _capacity;
        }

        public T DeQueue()
        {
            T elem = default(T);
            if (_count > 0)
            {
                elem = _arry[_head];
                _count--;
                _head++;
                _head = _head % _capacity;
            }
            return elem;
        }

        public void Clear()
        {
            _head = 0;
            _tail = 0;
            _count = 0;
        }

        public void Traverse()
        {
            for (int i = _head; i < _head + _count; i++)
            {
                int index = i % _capacity;
                Console.Write(_arry[index] + "  ");
            }
            Console.WriteLine();
        }
    }
}
