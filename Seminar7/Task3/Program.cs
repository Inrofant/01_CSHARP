// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine()!;

        if (!string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Согласные буквы: " + GetConsonants(input));
        }
        else
        {
            Console.WriteLine("Пустая строка. Пожалуйста, введите строку с латинскими буквами.");
        }
    }

    static string GetConsonants(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        char firstChar = input[0];
        if (IsConsonant(firstChar))
        {
            return firstChar + " " + GetConsonants(input.Substring(1));
        }
        else
        {
            return GetConsonants(input.Substring(1));
        }
    }

    static bool IsConsonant(char c)
    {
        // Проверка, является ли символ согласной буквой
        return char.IsLetter(c) && !"aeiouAEIOU".Contains(c);
    }
}
