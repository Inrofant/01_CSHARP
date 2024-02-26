// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void ReverseArray(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            // Меняем местами элементы, на которые указывают start и end
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            // Сдвигаем указатели
            start++;
            end--;
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        ReverseArray(array);

        Console.WriteLine("Перевернутый массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}