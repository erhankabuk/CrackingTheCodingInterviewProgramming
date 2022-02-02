using System;

namespace _1._8ZeroMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 0, 7, 8 }, { 9, 10, 11, 12 } };

            WriteMatrix(matrix);
            Console.WriteLine();
            NullifyMatrix(matrix);
            WriteMatrix(matrix);
        }

        static void NullifyMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            int[] indexes = NullifyColumnAndRow(matrix);

            for (int i = 0; i < column; i++)
            {
                matrix[indexes[0], i] = 0;
            }
            for (int i = 0; i < row; i++)
            {
                matrix[i, indexes[1]] = 0;
            }

        }

        static int[] NullifyColumnAndRow(int[,] matrix)
        {
            int[] indexofZero = new int[2];
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        indexofZero[0] = i;
                        indexofZero[1] = j;
                    }
                }
            }
            return indexofZero;
        }

        static void WriteMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
