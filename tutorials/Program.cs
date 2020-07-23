// Program.cs is the most important file
// It has the Main function & this function runs our app
// Class has - Data or attributes & Function or Methods
// Void when not returning anything
// Use 'int' when returning an interger & 'string' when returning string
//Class name should start with a capital letter because C# is case sensitive language
//When importing a class & function into Program.cs always write 'public' in front of it
//Class is collection of similar or related functions. For eg Recursion class has all problems related Recursion. Class name should began with capital letter
//Namespace is collection of similar or related classes. For eg 'Recursion', 'Array', etc are part of my tutorial so added under namespace 'tutorials'. namespace starts with small letter
//static modifier makes an item non-instantiable, it means the static item cannot be instantiated.

using System;
// using System.Collections.Generic;


namespace tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //In main function- see below
            // Console.WriteLine(GetSquare(3));
            // Console.WriteLine(GetSquare(9));
            // Console.WriteLine(GetProduct(9, 10));
            // Print();

            //From Recursion.cs
            // Console.WriteLine(Recursion.GetFactorial(2));
            // Console.WriteLine(Recursion.FibonacciSeries(6));
            // Console.WriteLine(Recursion.GetSum(10));
            // Console.WriteLine(Recursion.CalculatePower(2, 5));

            //From Array.cs
            // int[] Arr1 = Array.Create(4);
            // Array.Print(Arr1);
            // Array.Print(new int[] {1,5,8,9});

            // Console.WriteLine(Array.SearchByIndex(new int[] {2,4,6,7,8}, 7));

            // Array.Print(Array.InsertNum(new int[] {2,4,5,6,7,8}, 1, 2));

            // var a = new int[] {4,3,5,10,9,10};
            // Array.DeleteArray(a, 3);
            // Array.Print(a);

            // var c = Array.DelCreateNewArr(new int[] {4,3,5,10,9,10}, 3);
            // Array.Print(c);

            // var e = Array.ZerosAndNumbers(15);
            // Array.Print(e);

            // var f = Array.ReverseTheArray(new int[] {4,3,5,9,10});
            // Array.Print(f);
            // Array.Print(Array.ReverseInPlace(new int[] {4,3,5,9,10}));
            // Console.WriteLine();

            // var g = Array.MergeArray(new int[] {3,5,9}, new int[] {4,6,8,10,12,13});
            // Array.Print(g);


            //From 2DArray.cs
            // var d = Array2D.Create(2,2);
            // Array2D.Print2D(d);

            // var h = Array2D.CenterZeros(5, 6);
            // Array2D.Print2D(h);

            // var i = Array2D.Create(3, 3);
            // Array2D.Print2D(i);
            // Console.WriteLine();
            // Array2D.DiagonalFlip(i);
            // Array2D.Print2D(i);

            // var k = Array2D.Create(3, 3);
            // Array2D.Print2D(k);
            // Console.WriteLine();
            // var m = Array2D.DiagonalFlip(k);
            // Array2D.ReverseInPlace(m);
            // Array2D.Print2D(k);


            //From LinkedList.cs
            // var SLL = new LinkedList();
            // SLL.AddLast(20);
            // SLL.AddFirst(5);
            // SLL.AddLast(10);
            // SLL.AddLast(15);
            // SLL.AddAnywhere(6, 3);
            // SLL.Print();

            // var SortedList = new LinkedList();
            // SortedList.AddFirst(12);
            // SortedList.AddFirst(8);
            // SortedList.AddFirst(6);
            // SortedList.AddFirst(4);
            // SortedList.AddFirst(2);
            // SortedList.AddToSortedList(5);
            // var ab = SortedList.SearchValue(1);
            // Console.WriteLine(ab);
            // SortedList.Print();
            // Console.WriteLine();
            // SortedList.DeleteNode(1);
            // SortedList.Print();


            //From StackArray.cs
            // var stackarr = new StackArray();
            // stackarr.CreateStack(6);
            // stackarr.PushInStack(15);
            // stackarr.PushInStack(20);
            // stackarr.PushInStack(43);
            // stackarr.PushInStack(14);
            // stackarr.PushInStack(51);
            // stackarr.PushInStack(100);
            // stackarr.Print();
            // Console.WriteLine();

            // Console.WriteLine("Pop Value ="+ stackarr.PopOutOfStack());

            // stackarr.PeekTheStack();

            // Console.Write(stackarr.IsStackFull());
            // Console.WriteLine();

            // Console.Write(stackarr.IsStackEmpty());



            //From StackLL.cs
            // var stackLL = new StackLL();
            // stackLL.Push(4);
            // stackLL.Push(8);
            // stackLL.Push(9);
            // stackLL.Push(15);
            // stackLL.Print();
            // stackLL.Pop();
            // stackLL.Print();
            // var abc = stackLL.Peek();
            // Console.WriteLine(abc.Value);

            // Console.WriteLine(stackLL.IsEmpty());
            
            //From QueueLL.cs
            // var queue = new QueueLL();
            // queue.Enqueue(4);
            // queue.Enqueue(3);
            // queue.Enqueue(7);
            // queue.Enqueue(9);
            // queue.Print();
            // Console.WriteLine(queue.Dequeue());
            // queue.Enqueue(11);
            // Console.WriteLine(queue.Dequeue());
            // queue.Print();

            //From QueueArray.cs
            // var queue = new tutorials.QueueArray();
            // queue.CreateQueue(5);
            // queue.Enqueue(4);
            // queue.Enqueue(3);
            // queue.Enqueue(7);
            // queue.Enqueue(9);
            // queue.Print();
            // Console.WriteLine(queue.Dequeue());
            // queue.Enqueue(11);
            // Console.WriteLine(queue.Dequeue());
            // queue.Print();

            // var binTr = new BinaryTA(10);
            // binTr.Insert(10);
            // binTr.Insert(2);
            // binTr.Insert(13);
            // binTr.Insert(5);
            // binTr.Insert(70);
            // binTr.Insert(91);
            //binTr.InOrderTraversal();
            // binTr.PreOrderTraversal();
            // binTr.PostOrderTraversal();
            // binTr.LeveOrderTraversal();
            // binTr.DeleteNode(5);
            // binTr.LeveOrderTraversal();


            // var bintree = new BinaryTree();
            // bintree.Insert(10);
            // bintree.Insert(20);
            // bintree.Insert(30);
            // bintree.Insert(40);
            // bintree.Insert(50);
            // bintree.Insert(60);
            // bintree.Insert(70);

            // bintree.PreOrder();
            // Console.WriteLine();
            // bintree.PostOrder();
            // Console.WriteLine();
            // bintree.InOrder();
            // Console.WriteLine();
            // bintree.LevelOrderTraversal();

            // Console.WriteLine (bintree.Search(80).Data);

            Array.Print(Selectionsort.Sort(new int[] {91,0,1,10,0,-1,100}));
        }

        static int GetSquare(int num1)
        {
            return num1*num1;
        }

        static int GetProduct(int num1, int num2)
        {
            return num1*num2;
        }

         static void Print()
        {
            int [] Arr1 = {1,2,3,4,5,6};
            for (int i = 0; i < Arr1.Length; i++)
            {
                Console.WriteLine(Arr1[i]) ;
            }
        }
    }
}
