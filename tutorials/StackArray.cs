using System;

namespace tutorials
{
    class StackArray
    {
        //Introducing const topOfStack & an array 'stack' for use in the functions below
        private int topOfStack = -1;
        private int[] stack;


        //Creating a Stack by using array
        public void CreateStack(int arrayLength)
        {
            this.stack = new int[arrayLength];
        }

        //Pushing or Inserting in the Stack
        public void PushInStack(int pushValue)
        {
            if(topOfStack == this.stack.Length-1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {   topOfStack++;
                this.stack[topOfStack] = pushValue;
            }
        }

        //Popping or removing from the Stack
        public int PopOutOfStack()
        {
            int tempVar = 0;

            if(topOfStack == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {   tempVar = this.stack[topOfStack];
                topOfStack--;
            }
        return tempVar;
        }

        //Peeking or returning the topOfStack
        public void PeekTheStack()
        {
            if(topOfStack == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine(this.stack[topOfStack]);
            }
            
        }

        //Checking if the stack isEmpty
        public bool IsStackEmpty()
        {
            if(topOfStack == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checking if the stack isFull
        public bool IsStackFull()
        {
            if(topOfStack == this.stack.Length-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Printing the stack
        public void Print()
        {
            if(this.IsStackEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                for (int i = 0; i < this.stack.Length; i++)
                {
                    Console.Write(this.stack[i] + " ");
                }
            }
        }


        //Deleting the entire stack
        public void deletingStack()
        {
            this.stack = null;
        }
    }
}