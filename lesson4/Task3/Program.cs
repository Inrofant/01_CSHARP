// В ней требуется ввести строку с клавиатуры и
// сформировать новую из букв исходной строки.


using System;

class Program
{
    static string GetLetters(string s)
    {
        string letters = "";
        foreach (char e in s)
        {
            if (char.IsLetter(e))
            {
                letters += e;
            }
        }
        return letters;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine()!;
        string result = GetLetters(str);
        Console.WriteLine("Строка, содержащая только буквы:");
        Console.WriteLine(result);
    }
}