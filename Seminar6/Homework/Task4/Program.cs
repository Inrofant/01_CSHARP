// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

using System;

class Program
{
    static string ReverseWords(string input)
    {
        if (input == null)
        {
            return string.Empty;
        }
        
        string[] words = input.Split(' '); // Теперь перед вызовом Split проверяем input на null
        Array.Reverse(words);
        return string.Join(" ", words);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string? input = Console.ReadLine(); // Мы также можем использовать nullable string для ввода с консоли

        string reversed = ReverseWords(input ?? string.Empty); // Проверяем input на null и передаем пустую строку, если input равен null
        Console.WriteLine("Результат:");
        Console.WriteLine(reversed);
    }
}

