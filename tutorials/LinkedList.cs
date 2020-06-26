using System;

namespace tutorials
{
    class LinkedList
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

        //This function will add head to the new Linked List
        public void AddFirst (int NodeValue)
        {
            Node First = new Node();
            First.Value = NodeValue;
            if(head == null)
            {
            this.head = First;
            } 
            else
            {
                Node tempNode = this.head;
                First.Next = tempNode;
                this.head = First;
            }
        }

        //Add other nodes to the linked list one by one
        public void AddLast (int NodeValue)
        {
            if(this.head == null)
            {
                this.head = new Node();
                this.head.Value = NodeValue;
            }
            else
            {
                Node NewNode = new Node();
                NewNode.Value = NodeValue;
                NewNode.Next = null;

                Node tempNode = this.head;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = NewNode; 
            }
        }

        public void AddAnywhere (int NodeValue, int Position)
        {
            Node NewNode = new Node();
            NewNode.Value = NodeValue;
            NewNode.Next = null;
            int NumberOfCycles = 1;
            Node firstNode = this.head;

            while (NumberOfCycles < Position-1)
            {
                NumberOfCycles = NumberOfCycles + 1;
                firstNode = firstNode.Next;
            }
            Node ThirdNode = firstNode.Next;
            firstNode.Next = NewNode;
            NewNode.Next = ThirdNode;
        }

        //Adding node to a sorted list
        public void AddToSortedList (int NodeValue)
        {
            Node NewNode = new Node();
            NewNode.Value = NodeValue;
            NewNode.Next = null;
            Node firstNode = this.head;

            while(firstNode != null && firstNode.Value < NewNode.Value)
            {
                firstNode = firstNode.Next;
            }
        
            Node tempNode = this.head;
            while (tempNode.Next != firstNode)
            {
                tempNode = tempNode.Next;
            }

            tempNode.Next = NewNode;
            NewNode.Next = firstNode;
        }

        //Searching for a node & return its index
        public int SearchValue (int NodeValue)
        {
            Node SearchNode = new Node();
            SearchNode.Value = NodeValue;
            SearchNode.Next = null;
            Node firstNode = this.head;

            int count = 0;

            while(firstNode.Value != SearchNode.Value)
            {
                firstNode = firstNode.Next;
                count = count + 1;
                if (firstNode == null)
                {
                    return -1;
                }
            }
            return count;
        }

        public void DeleteNode (int NodeValue)
        {
            if(this.head.Value == NodeValue)
            {
                Node tempNode = this.head;
                this.head = this.head.Next;
                tempNode.Next = null;
                return;
            }

            Node traverserNode = this.head.Next;
            Node PrevNode = this.head;

            while (traverserNode.Value != NodeValue)
            {
                traverserNode = traverserNode.Next;
                PrevNode = PrevNode.Next;
                if (traverserNode == null)
                {
                    Console.WriteLine("Node not found");
                    return;
                }
            }
            PrevNode.Next = traverserNode.Next;
        }

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