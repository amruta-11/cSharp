// Program.cs is the most important file
// It has the Main function & this function runs our app
// Class has - Data or attributes & Function or Methods
// Void when not returning anything
// Use 'int' when returning an interger & 'string' when returning string
//Class name should start with a capital letter because C# is case sensitive language
//When importing a class & function into Program.cs always write 'public' in front of it
//Class is collection of similar or related functions. For eg Recursion class has all problems related Recursion. Class name should began with capital letter
//Namespace is collection of similar or related classes. For eg 'Recursion', 'Array', etc are part of my tutorial so added under namespace 'tutorials'. namespace starts with small letter
//

using System;

namespace tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Amy!");
            // Console.WriteLine(GetSquare(3));

            // Console.WriteLine(GetSquare(9));
            
            // Console.WriteLine(GetProduct(9, 10));
            // Print();
            
            // Console.WriteLine(Recursion.GetFactorial(2));
            
            // Console.WriteLine(Recursion.FibonacciSeries(6));
            
            // Console.WriteLine(Recursion.GetSum(10));
            
            // Console.WriteLine(Recursion.CalculatePower(2, 5));
            // int[] Arr1 = Array.Create(4);
            // Array.Print(Arr1);
            // Array.Print(new int[] {1,5,8,9});
            
            // Console.WriteLine(Array.SearchByIndex(new int[] {2,4,6,7,8}, 7));
            
            // Array.Print(Array.InsertNum(new int[] {2,4,5,6,7,8}, 1, 2));
            
            // Console.WriteLine("Enter numbers:");
            // var a = int.Parse(Console.ReadLine());
            // var b = int.Parse(Console.ReadLine());
            // Console.WriteLine(GetProduct(a, b));
            // Console.ReadKey();
            
            // var a = new int[] {4,3,5,10,9,10};
            // Array.DeleteArray(a, 3);
            // Array.Print(a);

            // var c = Array.DelCreateNewArr(new int[] {4,3,5,10,9,10}, 3);
            // Array.Print(c);

            // var d = Array2D.Create(2,2);
            // Array2D.Print2D(d);

            // var e = Array.ZerosAndNumbers(15);
            // Array.Print(e);

            // var f = Array.ReverseTheArray(new int[] {4,3,5,9,10});
            // Array.Print(f);
            // Array.Print(Array.ReverseInPlace(new int[] {4,3,5,9,10}));
            // Console.WriteLine();

            // var g = Array.MergeArray(new int[] {3,5,9}, new int[] {4,6,8,10,12,13});
            // Array.Print(g);

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

            var n = LinkedList.CreateSLL(4);
            LinkedList.Print(n);
            LinkedList.AddNode(n, 5);
            LinkedList.AddNode(n, 6);
            LinkedList.AddNode(n, 7);
            LinkedList.AddNode(n, 8);
            LinkedList.Print(n);
            
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
