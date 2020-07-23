using System;

namespace tutorials
{
    class BinaryTA
    {
        private int lastUsedIndex = 0;
        // private int index = 1;

        private int[] Arr;

        // Creating a binary tree using array
        // Constructor
        public BinaryTA(int length)
        {
            Arr = new int[length];
        }

        //Inserting in the tree
        public void Insert (int data)
        {
                if (lastUsedIndex == Arr.Length-1)
                {
                    Console.WriteLine("Array is Full");
                }
                else
                {
                    lastUsedIndex++;
                    Arr[lastUsedIndex] = data;
                }
        }

        //Search Value in Binary Tree
        public void Search (int searchValue)
        {
            for (int i = 1; i <= lastUsedIndex; i++)
            {
                if(Arr[i] == searchValue)
                {
                   Console.WriteLine(i); 
                }
                else
                {
                    Console.WriteLine("Value not found");
                }
            }
        }

        //In order traversal
        public void InOrderTraversal()
        {
            this.InOrderTraversalInternal(1);
        }
        private void InOrderTraversalInternal(int index)
        {
            if (index <= lastUsedIndex)
            {
                InOrderTraversalInternal(index * 2);
                Console.Write(Arr[index] + " ");
                InOrderTraversalInternal((index * 2)+1);
            }
        }


        //Pre-Order Traversal
        public void PreOrderTraversal()
        {
            this.PreOrderTraversalInternal(1);
        }
        public void PreOrderTraversalInternal (int index)
        {
            if (index <= lastUsedIndex)
            {
                Console.WriteLine(Arr[index]);
                PreOrderTraversalInternal(index * 2);
                PreOrderTraversalInternal((index * 2 ) + 1);
            }
        }


        //Post-Order Traversal
        public void PostOrderTraversal()
        {
            this.PostOrderTraversalInternal(1);
        }
        public void PostOrderTraversalInternal (int index)
        {
            if (index <= lastUsedIndex)
            {
                PostOrderTraversalInternal(index * 2);
                PostOrderTraversalInternal((index * 2 ) + 1);
                Console.Write(Arr[index] + " ");
            }
        }

        //Level Order Traversal
        public void LeveOrderTraversal()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }
        }

        //Deleting a node from tree
        public void DeleteNode (int deleteValue)
        {
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] == deleteValue)
                {
                    Arr[i] = Arr[lastUsedIndex];
                    Arr[lastUsedIndex] = 0;
                    lastUsedIndex-- ;
                }
            }
        }
    }
} 