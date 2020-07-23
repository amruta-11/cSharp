using System;
namespace tutorials
{
    class AVLTree
    {
        public class Node
        {
            //Value, Next & Prev are the properties of the Node class   
            public int Data;
            public Node Left;
            public Node Right;

            public Node(int data)
            {
                this.Data = data;
            }
        }

        //Set root node to null assuming the tree is empty
        private Node root = null;

        //Get height
        private int GetHeight (Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else if (node.Left == null && node.Right == null)
            {
                return 0;
            }
            else if (node.Left != null && node.Right == null)
            {
                return GetHeight(node.Left) + 1;
            }
            else if (node.Left == null && node.Right != null)
            {
                return GetHeight(node.Right) + 1;
            }
            else
            {
                int hl = GetHeight(node.Left);
                int hr = GetHeight(node.Right);
                return Math.Max(hl, hr) + 1;
            }
        }

        //Insert in the tree & balancing
        public void Insert (int data)
        {
            this.InsertInternal(this.root, data);
            // Check each node for balancing

        }
        private void InsertInternal (Node node, int data)
        {
            if (node == null)
            {
                node = new Node (data);
            }
            else if (data < node.Data)
            {
                if (node.Left != null)
                {
                    InsertInternal(node.Left, data);
                }
                else
                {
                    node.Left = new Node(data);
                    return;
                }
            }
            else
            {
                if (node.Right != null)
                {
                    InsertInternal(node.Right, data);
                }
                else 
                {
                    node.Right = new Node (data);
                    return;
                }
            }
        }

        // private void BalanceTree (Node node)
        // {
        //     int balanceFactor = this.GetHeight(node);

        //     if (balanceFactor == 0 || balanceFactor == -1 || balanceFactor == 1)
        //     {
        //         return;
        //     }
        //     else if ()
        //     {

        //     }
        //     else if ()
        //     {
                
        //     }

        // }

    }
}