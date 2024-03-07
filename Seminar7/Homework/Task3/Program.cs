// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

//пример: [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = { 1, 2, 5, 0, 10, 34 };
//         PrintArrayReversed(array, array.Length - 1);
//     }

//     static void PrintArrayReversed(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(array[index] + " ");
//             PrintArrayReversed(array, index - 1);
//         }
//     }
// }


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(' ');
        int[] array = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (int.TryParse(inputArray[i], out int result))
            {
                array[i] = result;
            }
            else
            {
                Console.WriteLine($"Ошибка парсинга элемента {inputArray[i]} в целое число.");
                return;
            }
        }
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReversed(array, index - 1);
        }
    }
}
