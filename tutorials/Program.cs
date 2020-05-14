// Program.cs is the most important file
// It has the Main function & this function runs our app
// Class has - Data or attributes & Function or Methods
// Void when not returning anything
// Use 'int' when returning an interger & 'string' when returning string
//Class name should start with a capital letter because C# is case sensitive language
//When import a class & function into Program.cs always write 'public' in front of it
//Class is collection of similar or related functions. For eg Recursion class has all problems related Recursion. Class name should began with capital letter
//Namespace is collection of similar or related classes. For eg 'Recursion', 'Array', etc are part of my tutorial so added under namespace 'tutorials'. namespace starts with small letter

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

            var c = Array.DelCreateNewArr(new int[] {4,3,5,10,9,10}, 3);
            Array.Print(c);

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
