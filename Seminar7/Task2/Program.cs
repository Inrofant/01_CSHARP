// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            PrintNaturalNumbers(1, n);
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
        }
    }

    static void PrintNaturalNumbers(int current, int n)
    {
        if (current <= n)
        {
            Console.Write(current + " ");
            PrintNaturalNumbers(current + 1, n);
        }
    }
}
