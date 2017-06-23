using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBasicAlgorithmCSharp
{
    public class XBinaryTree
    {
        public XBinaryTreeNode root;
        public int count;

        public void PreOrderTraversal()
        {
            Stack<XBinaryTreeNode> nodeStack = new Stack<XBinaryTreeNode>();
            XBinaryTreeNode node = root;
            while (node != null)
            {
                if (node.right != null)
                {

                }
            }
        }

        public void InOrderTraversal()
        {
            Stack<XBinaryTreeNode> nodeStack = new Stack<XBinaryTreeNode>();
            XBinaryTreeNode node = root;
            while (node != null && nodeStack.Count > 0)
            {
                while (node != null)
                {
                    nodeStack.Push(node);
                    node = node.left;
                }
                if (nodeStack.Count > 0)
                {
                    node = nodeStack.Pop();
                    Console.Write(node.value);
                    node = node.right;
                }
            }
        }

        public void PostOrderTraversal()
        {

        }
    }

    public class XBinaryTreeNode
    {
        public int index;
        public int value;
        public XBinaryTreeNode parent;
        public XBinaryTreeNode left;
        public XBinaryTreeNode right;
    }
}
