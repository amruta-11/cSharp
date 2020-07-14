using System;

namespace tutorials
{
    class QueueLL
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


        //Enqueue function
        public void Enqueue (int nodeValue)
        {
            Node newNode = new Node();
            newNode.Value = nodeValue;

            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                this.head = newNode;
                newNode.Next = temp;
            }
        }

        //Dequeue
        public int Dequeue()
        {

            if(this.head == null)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }


            if(this.head.Next == null)
            {
                Node tempH = this.head;
                this.head = null;
                return tempH.Value;
            }
            else
            {
                Node temp1 = this.head;
                Node temp2 = this.head.Next;

                while(temp2.Next != null)
                {
                    temp1 = temp1.Next;
                    temp2 = temp2.Next;
                }

                temp1.Next = null;
                return temp2.Value;  
            }
        }
    
        public void Print()
        {
            if(this.head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

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
