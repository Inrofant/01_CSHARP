// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = GenerateRandomMatrix(3, 3); // Создаем случайный массив 3x3
        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        SwapFirstAndLastRows(matrix);

        Console.WriteLine("Массив после замены строк:");
        PrintMatrix(matrix);
    }

    static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 101); // Случайные числа от 1 до 100
            }
        }

        return matrix;
    }

    static void SwapFirstAndLastRows(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);

        int[] tempRow = new int[columnCount];
        for (int j = 0; j < columnCount; j++)
        {
            tempRow[j] = matrix[0, j];
        }

        for (int j = 0; j < columnCount; j++)
        {
            matrix[0, j] = matrix[rowCount - 1, j];
        }

        for (int j = 0; j < columnCount; j++)
        {
            matrix[rowCount - 1, j] = tempRow[j];
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
