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
            Console.WriteLine(Recursion.GetSum(10));
             Console.WriteLine(Recursion.CalculatePower(2, 5));
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
