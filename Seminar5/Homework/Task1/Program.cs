// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Исходный двумерный массив
//         int[,] matrix = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         // Выводим исходный массив на экран
//         Console.WriteLine("Исходный массив:");
//         PrintMatrix(matrix);

//         // Запрашиваем позиции элемента
//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine());
//         Console.Write("Введите номер столбца: ");
//         int column = int.Parse(Console.ReadLine());

//         // Проверяем существование элемента и выводим его значение
//         if (ElementExists(matrix, row, column))
//         {
//             int elementValue = GetElementValue(matrix, row, column);
//             Console.WriteLine($"Значение элемента на позиции ({row}, {column}): {elementValue}");
//         }
//         else
//         {
//             Console.WriteLine($"Элемента на позиции ({row}, {column}) не существует.");
//         }
//     }

//     // Функция для проверки существования элемента по заданным координатам
//     static bool ElementExists(int[,] matrix, int row, int column)
//     {
//         return row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1);
//     }

//     // Функция для получения значения элемента по заданным координатам
//     static int GetElementValue(int[,] matrix, int row, int column)
//     {
//         return matrix[row, column];
//     }

//     // Функция для вывода двумерного массива на экран
//     static void PrintMatrix(int[,] matrix)
//     {
//         int rows = matrix.GetLength(0);
//         int columns = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность квадратной матрицы:");
        int size = int.Parse(Console.ReadLine()!);

        int[,] matrix = CreateRandomMatrix(size);

        Console.WriteLine("Массив:");
        PrintMatrix(matrix);

        Console.WriteLine("Введите позицию элемента для поиска (строка enter столбец):");
        int row = int.Parse(Console.ReadLine()!) - 1;
        int column = int.Parse(Console.ReadLine()!) - 1;

        int value = GetElementValue(matrix, row, column);
        Console.WriteLine(value != int.MinValue ?
            $"Значение элемента в позиции ({row + 1}, {column + 1}): {value}" :
            $"Элемента в позиции ({row + 1}, {column + 1}) не существует.");
    }

    static int[,] CreateRandomMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                matrix[i, j] = random.Next(1, 101); // Случайные числа от 1 до 100
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                Console.Write($"{matrix[i, j]} ");
            Console.WriteLine();
        }
    }

    static int GetElementValue(int[,] matrix, int row, int column)
    {
        int size = matrix.GetLength(0);
        return (row >= 0 && row < size && column >= 0 && column < size) ?
            matrix[row, column] : int.MinValue;
    }
}