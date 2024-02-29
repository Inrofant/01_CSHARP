// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4

// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Вызываем функцию для изменения элементов
        ChangeEvenIndices(matrix);

        // Выводим измененный массив на экран
        PrintMatrix(matrix);
    }

    // Функция для изменения элементов с четными индексами
    static void ChangeEvenIndices(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // Проверяем, являются ли оба индекса четными
                if (IsEven(i) && IsEven(j))
                {
                    // Заменяем элемент на его квадрат
                    matrix[i, j] *= matrix[i, j];
                }
            }
        }
    }

    // Функция для проверки четности числа
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Функция для вывода массива на экран
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("Измененный массив:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


