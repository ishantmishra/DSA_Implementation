namespace DSA_Implementation.Arrays
{
    public class Array2D
    {
        public static void ArrayPrint()
        {
            int[,] array2d =
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 } 
            };

            int rows = array2d.GetLength(0);
            int cols = array2d.GetLength(1);

            for (int i = 0; i < rows ; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(array2d[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}