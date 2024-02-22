// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Исходный массив
        int[] array = {1, 2, 3, 4, 5};

        // Создаем новый массив для записи произведений пар чисел
        int[] products = new int[array.Length / 2];

        // Проходим по исходному массиву и вычисляем произведения пар чисел
        for (int i = 0; i < array.Length / 2; i++)
        {
            products[i] = array[i] * array[array.Length - 1 - i];
        }

        // Выводим результаты
        Console.WriteLine("Произведения пар чисел:");
        foreach (int product in products)
        {
            Console.Write(product);
        }
    }
}
