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


            public static void Print(int[] Arr)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Console.WriteLine(Arr[i]);
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
        }
}