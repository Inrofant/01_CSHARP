// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = GenerateRandomMatrix(3, 3);

        Console.WriteLine("Сгенерированный массив:");
        PrintMatrix(matrix);

        int minRowIndex = FindRowWithMinSum(matrix);

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1}");
    }

    static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 101); // случайные числа от 1 до 100
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int FindRowWithMinSum(int[,] matrix)
    {
        int minRowSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rowSum += matrix[i, j];
            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }
}
