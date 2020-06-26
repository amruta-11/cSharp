using System; 

namespace tutorials
{
    class Array
    {
        //Create a new Array
        public static int[] Create(int length)
        {
            int[] arr1;
            arr1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr1[i] = i+1;
            }
            return arr1; 
        }

        //Print an Array
        public static void Print(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }
        }

        // Searching the given number & returning its Index
        public static int SearchByIndex(int[] Arr, int searchNum)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == searchNum)
                {
                    return i;
                }
            }
            throw new Exception("Number Not Found");
        }

        //Inserting a number at the given index in Array
        public static int[] InsertNum(int[] Arr, int NumtoInsert, int IndexNum)
        {
            int[] Arr1 = new int[Arr.Length + 1];

            Arr1[IndexNum] = NumtoInsert;

            for (int i = 0; i < IndexNum; i++)
            {
                Arr1[i] = Arr[i];
            }
            
            for (int i = IndexNum; i < Arr.Length; i++)
            {
                Arr1[i+1] = Arr[i];
            }
            return Arr1;
        }

        //Deleting a value at given index
        public static void DeleteArray (int[] Arr, int IndexNum) {

            if (IndexNum < Arr.Length)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[IndexNum] != 0 )
                    {
                        Arr[IndexNum] = int.MinValue;
                    }
                }
            }
            else
            {
                throw new Exception();
            }
        }


        //Deleting a number from array & adding remaining numbers to the new array
        public static int[] DelCreateNewArr (int[] Arr, int IndexNum1)
        {   
            int[] Arr1 = new int[Arr.Length-1];

            if (IndexNum1 < Arr.Length)
            {
                for (int i = 0; i < IndexNum1; i++)
                {
                    Arr1[i] = Arr[i];
                }
                for (int i = IndexNum1+1; i < Arr.Length; i++)
                {
                    Arr1[i-1] = Arr[i];
                }
            }
            return Arr1;
        }  
    

        //Creating array 0, 1, 0, 2, 0, 3, 0, 4.....
        public static int[] ZerosAndNumbers (int SizeOfArray)
        {
            int[] Arr1 = new int[SizeOfArray];
            int n = 1;

            for (int i = 0; i < SizeOfArray; i++)
            {
                if (i % 2 == 0)
                {
                    Arr1[i] = 0;
                }
                else
                {
                    Arr1[i] = n;
                     n = n+1;
                }
            }
            return Arr1;
        }

        //Reversing the given array
        public static int[] ReverseTheArray (int[] Arr1)
        {
            int[] Arr2 = new int[Arr1.Length];            

            for (int i = 0; i < Arr1.Length; i++)
            {
                Arr2[i] = Arr1[Arr1.Length- (i+1)];
            }
            return Arr2;
        }
        
        //Merging & rearranging elements in two arrays in ascending order
        public static int[] MergeArray (int[] Arr1, int[] Arr2)
        {
            int[] Arr3 = new int[Arr1.Length + Arr2.Length];
            var Index1 = 0;
            var Index2 = 0;

            for (int i3 = 0; i3 < Arr3.Length; i3++)
            {
                if (Index1 < Arr1.Length && Index2 < Arr2.Length) 
                {
                    if ( Arr1[Index1] > Arr2[Index2])
                    {
                        Arr3[i3] = Arr2[Index2];
                        Index2++;
                    }
                    else
                    {
                        Arr3[i3] = Arr1[Index1];
                        Index1++;
                    }
                }
                else if (Index1 < Arr1.Length)
                {
                    Arr3[i3] = Arr1[Index1];
                    Index1++;
                }
                else 
                {
                    Arr3[i3] = Arr2[Index2];
                    Index2++;
                }
            }
            return Arr3;
        }

        //Mirroring the array from center element
            public static int[] ReverseInPlace (int[] Arr1)
        {            
            for (int i = 0; i < (Arr1.Length/2); i++)
            {
                var a = Arr1[i];
                var b = Arr1[Arr1.Length - (i+1)];
                Arr1[i] = b;
                Arr1[Arr1.Length - (i+1)] = a;
            }
            return Arr1;
        }
    }
}