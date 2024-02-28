// сформировать двумерный массив из целых чисел и вывести на
// экран элементы, которые удовлетворяют некоторому критерию. Под этим
// критерием будем понимать чётность суммы цифр у числа.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = CreateMatrix(5, 4); // Создание двумерного массива 5x4
        ShowMatrix(matrix); // Вывод матрицы на экран
        Console.WriteLine("Элементы, удовлетворяющие критерию (четность суммы цифр):");
        PrintElementsWithCriteria(matrix); // Вывод элементов, удовлетворяющих критерию
    }

    // Создание двумерного массива размера rowCount x columnCount с случайными значениями
    static int[,] CreateMatrix(int rowCount, int columnCount)
    {
        int[,] matrix = new int[rowCount, columnCount];
        Random rnd = new Random();

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                matrix[i, j] = rnd.Next(1, 1000); // Заполнение элементов случайными значениями от 1 до 999
            }
        }

        return matrix;
    }

    // Вывод двумерного массива на экран
    static void ShowMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                Console.Write($"{matrix[i, j],4} "); // Вывод элемента с выравниванием по ширине 4 символа
            }
            Console.WriteLine(); // Переход на новую строку после каждой строки матрицы
        }
    }

    // Вывод элементов, удовлетворяющих критерию (четность суммы цифр)
    static void PrintElementsWithCriteria(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                if (IsSumOfDigitsEven(matrix[i, j])) // Проверка четности суммы цифр числа
                {
                    Console.WriteLine($"Элемент[{i}, {j}]: {matrix[i, j]}"); // Вывод элемента и его индексов
                }
            }
        }
    }

    // Проверка четности суммы цифр числа
    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10; // Получение последней цифры числа и добавление её к сумме
            number /= 10; // Удаление последней цифры числа
        }
        return sum % 2 == 0; // Возвращение результата проверки на четность суммы цифр числа
    }
}
