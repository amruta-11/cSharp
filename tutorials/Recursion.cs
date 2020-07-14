using System;

namespace tutorials
{
    public static class Recursion
    {
        //This function gets the factorial (!) of 'num'
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

        //Gets sum. if num = 4 then sum = 5+4+3+2+1 = 15
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


        // Gets the value. if baseNum=2 & exponent=3 then 2^3= 8
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
