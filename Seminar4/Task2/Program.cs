// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int N = int.Parse(Console.ReadLine()!);

        // Создаем массив из N случайных целых чисел
        int[] array = new int[N];
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(1, 100); // Генерируем случайное число от 1 до 100
        }

        // Выводим массив на экран
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);

        // Находим количество чисел, которые оканчиваются на 1 и делятся нацело на 7
        int count = CountNumbers(array);
        Console.WriteLine($"Количество чисел, оканчивающихся на 1 и делящихся нацело на 7: {count}");
    }

    static int CountNumbers(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 10 == 1 && num % 7 == 0)
            {
                count++;
            }
        }
        return count;
    }

    // Функция для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}