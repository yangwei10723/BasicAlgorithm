using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// leftNodeIndexInArray = 2 * nodeIndex; rightNodeIndexInArray = 2 * nodeIndex + 1;
// 适合完全二叉树，
public class XArrayTree
{
    private int _length;
    private int[] _nodeArray;
    private int _count;

    public XArrayTree(int length)
    {
        _length = length;
        _nodeArray = new int[length];
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }

    public int FindNode(int value)
    {
        int index = -1;
        for (int i = 0; i < _length; i++)
        {
            if (_nodeArray[i] == value)
            {
                index = i;
                break;
            }
        }
        return index;
    }

    public bool Insert(int index, int value)
    {
        if (_nodeArray[index] == 0)
        {
            _nodeArray[index] = value;
            return true;
        }
        return false;
    }

    public void Traversal()
    {
        for (int i = 0; i < _length; i++)
        {
            Console.WriteLine(_nodeArray[i]);
        }
    }
}

