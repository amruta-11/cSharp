using System;

namespace tutorials
{
    public static class Recursion
    {
        public static int GetFactorial (int num)
        {
            if(num == 0)
            {
                return 1;
            }
            return num * GetFactorial(num-1);
        }

        //Find Fibonacci number at 'n'th = num  place
        public static int FibonacciSeries (int num)
        {
            if(num < 1)
            {
                throw new Exception();
            }
            else if (num == 1 || num == 2)
            {
                return (num-1);
            }
            else
            {
                return (FibonacciSeries(num-1) + FibonacciSeries(num-2));
            }
        }

        public static int GetSum (int num)
        {
            if(num == 0)
            {
                return 0;
            }
            else
            {
                return num + GetSum(num-1);
            }
        }

        public static int CalculatePower (int baseNum, int exponent)
        {
            if(exponent == 0)
            {
                return 1;
            }
            else if(baseNum == 0)
            {
                return 0;
            }
            else
            {
                return baseNum * CalculatePower(baseNum, exponent-1);
            }
        }
    }
}
