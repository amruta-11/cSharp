using System;

namespace tutorials
{
    class StackLL
    {
        //LinkedList:
        //Head & reference to the next node
        //Created a Node class, so that it can be used everywhere & make it public
        public class Node
        {
            //Value & Next are the properties of the Node class
            public int Value;
            public Node Next;
        }

        //Set head node to null assuming the LL is empty
        private Node head = null;

        //Push in the stack
        public void Push (int nodeValue)
        {
            Node NewNode = new Node();
            NewNode.Value = nodeValue;
            if(head == null)
            {
            this.head = NewNode;
            } 
            else
            {
                Node tempNode = this.head;
                this.head = NewNode;
                this.head.Next = tempNode;
            }
        }

        //Pop in the stack
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node tempNode = this.head.Next;
                this.head = null;
                this.head = tempNode;
            }
        }

        //Peeking or returning the top Of Stack
        public Node Peek()
        {
            if (head == null)
            {
                return null;
            }
            else
            {
                return this.head;
            }

        }

        //isEmpty
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }

        //Print Stack
         public void Print()
        {
            Node tempNode = this.head;
            while (tempNode != null)
            {
                Console.Write(tempNode.Value + " ");
                tempNode = tempNode.Next;
            }
            Console.WriteLine();
        }
    }
}