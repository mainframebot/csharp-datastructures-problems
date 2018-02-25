using System;

namespace MatrixProblemsLesson
{
    public class SquareMatrixMultiplication
    {
        public int[,] Solution(int[,] arrayA, int[,] arrayB)
        {
            if (arrayA.GetLength(0) != arrayA.GetLength(1))
                throw new ArgumentException();
            if (arrayB.GetLength(0) != arrayB.GetLength(1))
                throw new ArgumentException();

            if (arrayA.GetLength(0) != arrayB.GetLength(0))
                throw new ArgumentException();

            var matrixSize = arrayA.GetLength(0);

            var result = new int[matrixSize, matrixSize];

            for (var row = 0; row < matrixSize; row++)
            {
                for (var col = 0; col < matrixSize; col++)
                {
                    result[row, col] = 0;
                    for (var k = 0; k < matrixSize; k++)
                    {
                        result[row, col] += arrayA[row, k]*arrayB[k, col];
                    }
                }
            }

            return result;
        }
    }
}
