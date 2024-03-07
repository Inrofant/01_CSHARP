// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

//пример 
// 123 => 6
// 63 => 9

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine()!;
        
        if (int.TryParse(input, out int number))
        {
            int sum = SumOfDigits(number);
            Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }

    static int SumOfDigits(int number)
    {
        if (number < 10)
        {
            return number;
        }
        else
        {
            int lastDigit = number % 10;
            int remainingDigits = number / 10;
            return lastDigit + SumOfDigits(remainingDigits);
        }
    }
}