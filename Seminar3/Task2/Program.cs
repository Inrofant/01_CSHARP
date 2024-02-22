// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем генератор случайных чисел
        Random random = new Random();
        
        // Создаем массив из 10 элементов
        int[] array = new int[10];

        // Заполняем массив случайными числами из промежутка [-10, 10]
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11); // Генерируем число от -10 до 10 включительно
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем знак у элементов массива
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -array[i];
        }

        // Выводим измененный массив
        Console.WriteLine("\nМассив после замены знаков:");
        PrintArray(array);
    }

    // Метод для вывода массива на консоль
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
