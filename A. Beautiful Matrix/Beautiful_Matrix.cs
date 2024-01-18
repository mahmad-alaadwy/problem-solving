//using proplems_solved.A._Beautiful_Matrix;

//int[,] nk = new int[5, 5];

//// Read input values and populate the array
//for (int i = 0; i < 5; i++)
//{
//    string[] inputValues = Console.ReadLine().Trim().Split(' ');

//    for (int j = 0; j < 5; j++)
//    {
//        nk[i, j] = Convert.ToInt32(inputValues[j]);
//    }
//}

//int NumberOfSwaps = Beautiful_Matrix.numberOfSwaps(nk);
//Console.WriteLine(NumberOfSwaps);



namespace proplems_solved.A._Beautiful_Matrix
{
    public static class Beautiful_Matrix
    {

        private static (int, int) FindPosition(int[,] array, int value)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] == value)
                    {
                        return (i, j); // Return the position if the value is found
                    }
                }
            }

            return (-1, -1); // Return (-1, -1) if the value is not found
        }

        public static int numberOfSwaps(int[,] matrix)
        {
            //i'll assume that the swaps are the distance to the middle of the matrix
            (int x,int y) = Beautiful_Matrix.FindPosition(matrix, 1);
            int swaps=Math.Abs(x - 2) +Math.Abs(y - 2);
            return swaps;
        }

    }

}
