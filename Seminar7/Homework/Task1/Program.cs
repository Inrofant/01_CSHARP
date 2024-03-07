// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

//пример    M = 1; N = 5 -> "1, 2, 3, 4, 5"
//          M = 4; N = 8 -> "4, 5, 6, 7, 8"

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}: {GetNaturalNumbers(m, n)}");
    }

    static string GetNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            return string.Empty;
        }

        if (m == n)
        {
            return m.ToString();
        }

        return m + ", " + GetNaturalNumbers(m + 1, n);
    }
}
