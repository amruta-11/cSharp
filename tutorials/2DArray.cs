using System; 

namespace tutorials
{
    class Array2D
    {
        //For 2D Array(R X C):
        //Array.GetLength(0) = Number of Rows
        //Array.GetLength(1) = Number of Columns

        //Create a new 2D Array
        public static int[,] Create(int NumofRows, int NumofCol)
        {
            int[,] arr1;
            arr1 = new int [NumofRows, NumofCol];

            for (int i = 0; i < NumofRows; i++)
            {
                for (int j = 0; j < NumofCol; j++)
                {
                    arr1[i,j] = (i*NumofCol) + (j+1);
                }
            }
            return arr1;
        }

        //Print 2D Array
        public static void Print2D (int[,] Arr1)
        {
            for (int i = 0; i < Arr1.GetLength(0); i++)
            {
                for (int j = 0; j < Arr1.GetLength(1); j++)
                {
                    Console.Write(Arr1[i, j] + " ");
                }
                Console.Write('\n');
            }
     
        }

        //2DArray center elements zero & border elements one
        public static int[,] CenterZeros (int r, int c)
        {
            int[,] arr1;
            arr1 = new int [r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if ( i == 0 || i == (r-1) || j == 0 || j == (c-1) )
                    {
                        arr1[i,j] = 1;
                    }
                    else
                    {
                        arr1[i,j] = 0;
                    }
                }
            }
            return arr1;
        }

        
        //Flipping elements across Diagonal
        public static int[,] DiagonalFlip (int[,] Arr1)
        {   
            for (int i = 0; i < Arr1.GetLength(0); i++)
            {
                for (int j = 0; j < Arr1.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        var a = Arr1[i,j];
                        var b = Arr1[j,i];
                        
                        Arr1[i,j] = b;
                        Arr1[j,i] = a;                    
                    }
                }
            }
            return Arr1;
        }

        //Flipping elements by 180 degrees or Mirror flip
        public static int[,] ReverseInPlace (int[,] Arr1)
        {            
            for (int i = 0; i < Arr1.GetLength(0); i++)
            {
                for (int j = 0; j < (Arr1.GetLength(1))/2 ; j++)
                {
                    var a = Arr1[i,j];
                    var b = Arr1[i, Arr1.GetLength(1)-(j+1)];
                    Arr1[i,j] = b;
                    Arr1[i, Arr1.GetLength(1) - (j+1)] = a;
                }
            }
            return Arr1;
        }
    }
}