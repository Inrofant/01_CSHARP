//  Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

using System;

class Program
{
    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }
        return evenCount;
    }

    static void Main(string[] args)
    {
        // Создаем массив из случайных трёхзначных чисел
        int[] array = new int[10];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // // Выводим массив на экран
        // Console.WriteLine("Массив:");
        // foreach (int number in array)
        // {
        //     Console.Write(number + " ");
        // }
        // Console.WriteLine();

        // Получаем количество чётных чисел с помощью функции и выводим на экран
        int evenCount = CountEvenNumbers(array);
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }
}