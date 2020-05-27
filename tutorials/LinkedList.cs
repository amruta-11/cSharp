using System; 

namespace tutorials
{

    //Created a Node class, so that it can be used everywhere & make it public
    public class Node
    {
        public int Value;
        public Node Next;
    }

    class LinkedList
    {
        //'CreateSLL' function creates a new Linked List
        public static Node CreateSLL(int NodeValue)
        {
            Node Head = null;
            Node First = new Node();
            First.Value = NodeValue;
            First.Next = null;
            Head = First;

            return Head;
        }

        //Add nodes to the linked list one by one
        public static void AddNode (Node Head, int NodeValue)
        {
            Node NewNode = new Node();
            NewNode.Value = NodeValue;
            NewNode.Next = null;

            Node TempNode = Head;
            while (TempNode.Next != null)
            {
                TempNode = TempNode.Next;
            }

            TempNode.Next = NewNode; 
        }


        public static void Print(Node Head)
        {
            Node TempNode = Head;
            while (TempNode != null)
            {
                Console.Write(TempNode.Value + " ");
                TempNode = TempNode.Next;
            }
            Console.WriteLine();
        }
    }
}