// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

using System;

class Program
{
    static void Main(string[] args)
    {
        // Генерируем случайный массив
        int[,] matrix = GenerateRandomMatrix(5, 5);

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        // Находим индексы наименьшего элемента
        int[] minIndices = FindMinElementIndices(matrix);

        // Создаем новый массив без строки и столбца с минимальным элементом
        int[,] modifiedMatrix = RemoveRowAndColumn(matrix, minIndices[0], minIndices[1]);

        // Выводим измененный массив
        Console.WriteLine("\nМассив после удаления строки и столбца с минимальным элементом:");
        PrintMatrix(modifiedMatrix);
    }

    // Генерация случайного массива
    static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        Random rnd = new Random();
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = rnd.Next(1, 101); // Случайные числа от 1 до 100
            }
        }
        return matrix;
    }

    // Вывод массива на экран
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Поиск индексов минимального элемента
    static int[] FindMinElementIndices(int[,] matrix)
    {
        int minElement = matrix[0, 0];
        int minRowIndex = 0;
        int minColumnIndex = 0;
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                    minRowIndex = i;
                    minColumnIndex = j;
                }
            }
        }
        return new int[] { minRowIndex, minColumnIndex };
    }

    // Удаление строки и столбца с минимальным элементом
    static int[,] RemoveRowAndColumn(int[,] matrix, int rowIndex, int columnIndex)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] result = new int[rows - 1, columns - 1];
        int resultRow = 0;
        for (int i = 0; i < rows; i++)
        {
            if (i == rowIndex)
            {
                continue; // Пропускаем строку с минимальным элементом
            }
            int resultColumn = 0;
            for (int j = 0; j < columns; j++)
            {
                if (j == columnIndex)
                {
                    continue; // Пропускаем столбец с минимальным элементом
                }
                result[resultRow, resultColumn] = matrix[i, j];
                resultColumn++;
            }
            resultRow++;
        }
        return result;
    }
}
