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
        Console.WriteLine(node.index + "\t" + node.value);
        if (node.leftNode != null)
        {
            PreorderTraversal(node.leftNode);
        }
        if (node.rightNode != null)
        {
            PreorderTraversal(node.rightNode);
        }
    }

    public void InorderTraversal(XBinaryTreeNode node)
    {
        // left -> root -> right
        if (node != null)
        {
            if (node.leftNode != null)
            {
                PreorderTraversal(node.leftNode);
            }
            Console.WriteLine(node.index + "\t" + node.value);
            if (node.rightNode != null)
            {
                PreorderTraversal(node.rightNode);
            }
        }
    }

    public void PostOrderTraversal(XBinaryTreeNode node)
    {
        // left -> right -> root
        if (node != null)
        {
            if (node.leftNode != null)
            {
                PreorderTraversal(node.leftNode);
            }
            if (node.rightNode != null)
            {
                PreorderTraversal(node.rightNode);
            }
            Console.WriteLine(node.index + "\t" + node.value);
        }
    }

    public void LevelOrderTraversal(XBinaryTreeNode node)
    {

    }
}


public class XBinaryTreeNode
{
    public int index;
    public int value;
    public XBinaryTreeNode leftNode;
    public XBinaryTreeNode rightNode;
}

