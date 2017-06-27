using System;
using System.Collections.Generic;

public class XBinaryTree
{
    public XBinaryTreeNode root;
    private int count;


    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool InsertNode(int index, XBinaryTreeNode node)
    {
        throw new NotImplementedException();
    }

    public int FindNode(XBinaryTreeNode node)
    {
        throw new NotImplementedException();
    }

    public void PreorderTraversal(XBinaryTreeNode node)
    {
        // root -> left -> right
        if (node != null)
        {
            Console.WriteLine(node.index + "\t" + node.value);
            PreorderTraversal(node.leftNode);
            PreorderTraversal(node.rightNode);
        }
    }

    public void PreOrderTraversalStack(XBinaryTreeNode node)
    {
        Stack<XBinaryTreeNode> stack = new Stack<XBinaryTreeNode>();
        while (node != null || stack.Count > 0)
        {
            while (node != null)
            {
                stack.Push(node);
                Console.WriteLine(node.index + "\t" + node.value);
                node = node.leftNode;
            }

            if (stack.Count > 0)
            {
                XBinaryTreeNode theNode = stack.Pop();
                node = theNode.rightNode;
            }
        }
    }

    public void InorderTraversal(XBinaryTreeNode node)
    {
        // left -> root -> right
        if (node != null)
        {
            PreorderTraversal(node.leftNode);
            Console.WriteLine(node.index + "\t" + node.value);
            PreorderTraversal(node.rightNode);
        }
    }

    public void PostOrderTraversal(XBinaryTreeNode node)
    {
        // left -> right -> root
        if (node != null)
        {
            PreorderTraversal(node.leftNode);
            PreorderTraversal(node.rightNode);
            Console.WriteLine(node.index + "\t" + node.value);
        }
    }

    public void PostOrderTraversalStack(XBinaryTreeNode node)
    {
        Stack<XBinaryTreeNode> stack = new Stack<XBinaryTreeNode>();
        while (node != null || stack.Count > 0)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.leftNode;
            }

            if (stack.Count > 0)
            {
                XBinaryTreeNode theNode = stack.Pop();
                Console.WriteLine(theNode.index + "\t" + theNode.value);
                node = theNode.rightNode;
            }
        }
    }

    public void LevelOrderTraversal(XBinaryTreeNode node)
    {
        // 二叉树二维结构线性化
        if (node != null)
        {
            Queue<XBinaryTreeNode> queue = new Queue<XBinaryTreeNode>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                XBinaryTreeNode theNode = queue.Dequeue();
                Console.WriteLine(theNode);
                if (theNode.leftNode != null)
                {
                    queue.Enqueue(theNode.leftNode);
                }
                if (theNode.rightNode != null)
                {
                    queue.Enqueue(theNode.rightNode);
                }
            }
        }
    }
}


public class XBinaryTreeNode
{
    public int index;
    public int value;
    public XBinaryTreeNode leftNode;
    public XBinaryTreeNode rightNode;
}

