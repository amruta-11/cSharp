using System;
using System.Collections;

namespace tutorials
{
    class BinaryTree
    {
        //Head & reference to the next node
        //Created a Node class, so that it can be used everywhere & make it public
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


        //Insert
        public void Insert (int data)
        {
            if (this.root != null)
            {
                var queue = new Queue();
                queue.Enqueue(this.root);

                while (queue.Count > 0)
                {
                    Node temp = (Node)queue.Dequeue();

                    if (temp.Left != null)
                    {
                        queue.Enqueue(temp.Left);
                    }
                    else
                    {
                        temp.Left = new Node(data);
                        return;
                    }

                    if (temp.Right != null)
                    {
                        queue.Enqueue(temp.Right);
                    }
                    else
                    {
                        temp.Right = new Node(data);
                        return;
                    }
                }
            }
            else
            {
                this.root = new Node(data);
            }
        }


        //Level order traversal
        public void LevelOrderTraversal ()
        {
            var queue = new Queue();
            queue.Enqueue(this.root);

            while (queue.Count > 0)
            {
                Node temp = (Node)queue.Dequeue();
                Console.Write(temp.Data + " ");
                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }
        }

        //PreOrder Traversal
        public void PreOrder()
        {
            this.PreOrderTraversal(root);
        }
        public void PreOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Console.Write(node.Data+ " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        //Post Order
        public void PostOrder()
        {
            this.PostOrderTraversal(root);
        }
        public void PostOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Data+ " ");
            }
        }


        //In order traversal
        public void InOrder()
        {
            this.InOrderTraversal(root);
        }
        public void InOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Data+ " ");
                InOrderTraversal(node.Right);
               
            }
        }


        //Search in the Binary tree
        public Node Search(int searchValue)
        {
            return this.SearchInternal(searchValue, root);
        }

        private Node SearchInternal (int searchValue, Node node)
        {
            if (node == null)
            {
                return null;
            }
            else
            {
                if (node.Data == searchValue)  
                {
                    return node;
                } 
                else
                {
                    Node temp = SearchInternal(searchValue, node.Left);
                    if (temp == null)
                    {
                        return SearchInternal(searchValue, node.Right);
                    }
                    else
                    {
                        return temp;
                    }
                }
            }
        }

    }
}