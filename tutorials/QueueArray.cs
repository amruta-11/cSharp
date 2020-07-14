using System;

namespace tutorials
{
    class QueueArray
    //Queue - First in First Out (FIFO)
    {
        private int[] Queue;
        private int endOfQueue = -1;
        private int startOfQueue = -1;

        //Creating a queue by using array
        public void CreateQueue(int arrayLength)
        {
            this.Queue = new int[arrayLength];
        }

        //Checking start & end of the queue
        public bool isFull()
        {
            if (endOfQueue - startOfQueue < -1)
            {
                return false;
            }
            if (endOfQueue - startOfQueue == -1)
            {
                return true;
            }
            if (endOfQueue == this.Queue.Length-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        //Enqueue in the queue
        public void Enqueue (int pushValue)
        {
            if(this.isFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {   
                endOfQueue++;
                if(endOfQueue > this.Queue.Length-1)
                {
                    endOfQueue = 0;
                }
                if (startOfQueue == -1)
                {
                    startOfQueue++;
                }
                this.Queue[endOfQueue] = pushValue;
            }
        }

        //Dequeue
        public int Dequeue()
        {
            if(startOfQueue == -1)
            {
                return -1;
            }
            else
            {
                int temp = Queue[startOfQueue];
                if(startOfQueue == endOfQueue)
                {
                    startOfQueue = endOfQueue = -1;
                }
                else
                {
                    startOfQueue++;
                    if(startOfQueue > this.Queue.Length-1)
                    {
                        startOfQueue = 0;
                    }
                }
                return temp;
            }
        }

        //Print Queue
        public void Print()
        {
            if(this.startOfQueue <= this.endOfQueue)
            {
                for (int i = this.startOfQueue; i <= this.endOfQueue; i++)
                {
                    Console.Write(this.Queue[i] + " ");
                }
            }
            else
            {
                for (int i = this.startOfQueue; i < this.Queue.Length; i++)
                {
                    Console.Write(this.Queue[i] + " ");
                }
                for (int i = 0; i <= this.endOfQueue; i++)
                {
                    Console.Write(this.Queue[i] + " ");
                }
            }
        }
    }
}