//213047

using System;

class Program
{
    const int SIZE = 3;

    static void Main()
    {
        int[,] matrixA = new int[SIZE, SIZE];
        int[,] matrixB = new int[SIZE, SIZE];

        Console.WriteLine("Enter the elements for Matrix A:");
        ReadMatrix(matrixA);

        Console.WriteLine("\nEnter the elements for Matrix B:");
        ReadMatrix(matrixB);

        int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

        Console.WriteLine("\nResultant Matrix after multiplication (A x B):");
        PrintMatrix(resultMatrix);
    }

    static void ReadMatrix(int[,] matrix)
    {
        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                Console.Write($"Enter element at position [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int[,] result = new int[SIZE, SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < SIZE; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
