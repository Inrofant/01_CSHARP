// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine()!; // Считываем строку с консоли
        int vowelsCount = CountVowels(input); // Определяем количество гласных в строке
        Console.WriteLine($"Количество гласных в строке: {vowelsCount}");
    }

    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (IsVowel(c))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsVowel(char c)
    {
        // Проверяем, является ли символ гласной буквой в нижнем регистре
        return "aeiou".Contains(c);
    }
}
