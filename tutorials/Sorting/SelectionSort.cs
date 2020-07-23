using System;

namespace tutorials
{
    public static class Selectionsort {
        public static int[] Sort(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndx = i;
                for (int j = i+1; j < arr.Length; j++)                   
                {
                    if (arr[minIndx] > arr[j])
                    {
                        minIndx = j;
                    }
                }

                if (i != minIndx) {
                    int temp = arr[i];
                    arr[i] = arr[minIndx];
                    arr[minIndx] = temp;
                }
            }
            return arr;
        }
    }    
}
