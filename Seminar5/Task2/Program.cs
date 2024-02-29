// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите размерность квадратной матрицы:");
//         int n;
//         if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
//         {
//             Console.WriteLine("Некорректный ввод размерности.");
//             return;
//         }

//         int[,] matrix = new int[n, n];

//         Console.WriteLine("Введите элементы матрицы:");
//         for (int i = 0; i < n; i++)
//         {
//             string input = Console.ReadLine();
//             string[] elements = input.Split(' ');
//             if (elements.Length != n)
//             {
//                 Console.WriteLine("Некорректное количество элементов.");
//                 return;
//             }
//             for (int j = 0; j < n; j++)
//             {
//                 if (!int.TryParse(elements[j], out matrix[i, j]))
//                 {
//                     Console.WriteLine("Некорректное значение элемента.");
//                     return;
//                 }
//             }
//         }

//         Console.WriteLine("Сумма элементов на главной диагонали: " + GetMainDiagonalSum(matrix));
//     }

//     static int GetMainDiagonalSum(int[,] matrix)
//     {
//         int sum = 0;
//         int n = matrix.GetLength(0);
//         for (int i = 0; i < n; i++)
//         {
//             sum += matrix[i, i];
//         }
//         return sum;
//     }
// }


using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем размерность квадратной матрицы
        Console.WriteLine("Введите размерность квадратной матрицы:");
        int n = int.Parse(Console.ReadLine());

        // Создаем матрицу с случайными элементами
        int[,] matrix = GenerateRandomMatrix(n);

        // Выводим матрицу на экран
        PrintMatrix(matrix);

        // Находим и выводим сумму элементов на главной диагонали
        int sum = SumMainDiagonal(matrix);
        Console.WriteLine($"Сумма элементов на главной диагонали: {sum}");
    }

    // Функция для создания квадратной матрицы с случайными элементами
    static int[,] GenerateRandomMatrix(int n)
    {
        Random rnd = new Random();
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(1, 101); // случайные числа от 1 до 100
            }
        }
        return matrix;
    }

    // Функция для вывода матрицы на экран
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("Матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Функция для вычисления суммы элементов на главной диагонали
    static int SumMainDiagonal(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }
        return sum;
    }
}
