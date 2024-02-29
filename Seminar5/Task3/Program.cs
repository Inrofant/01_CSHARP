// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.

// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив
        int[,] matrix = {
            {2, 3, 4, 3},
            {4, 3, 4, 1},
            {2, 9, 5, 4}
        };

        // Вызываем функцию для вычисления средних арифметических значений по строкам
        int[] averages = CalculateRowAverages(matrix);

        // Выводим исходный двумерный массив на экран
        Console.WriteLine("Исходный двумерный массив:");
        PrintMatrix(matrix);

        // Выводим новый одномерный массив средних арифметических значений по строкам на экран
        Console.WriteLine("Средние арифметические значения по строкам:");
        PrintArray(averages);
    }

    // Функция для вычисления средних арифметических значений по строкам
    static int[] CalculateRowAverages(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] averages = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
            }
            averages[i] = sum / cols;
        }

        return averages;
    }

    // Функция для вывода двумерного массива на экран
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Функция для вывода одномерного массива на экран
    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
