// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел (не более 8):");
        int N = Convert.ToInt32(Console.ReadLine()!);

        if (N > 8)
        {
            Console.WriteLine("Число должно быть не более 8.");
            return;
        }

        int[] array = new int[N];
        Random rand = new Random();

        Console.WriteLine("Массив случайных чисел:");
        for (int i = 0; i < N; i++)
        {
            array[i] = rand.Next(10); // случайное число от 0 до 9
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int number = 0;
        for (int i = 0; i < N; i++)
        {
            number = number * 10 + array[i];
        }

        Console.WriteLine("Сформированное число: " + number);
    }
}