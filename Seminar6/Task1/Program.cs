// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива.


// string CharsofString(char[] arr)
// {
//     string st = "";
//     foreach (char item in arr)
//     {
//         st += item;
//     }
//     return st;
// }

// char [] chars = new char[] {'a', 'b', 'c', 'd'};
// Console.WriteLine(CharsofString(chars));

using System;

class Program
{
    static void Main(string[] args)
    {
        char[] charArray = { 'H', 'e', 'l', 'l', 'o' }; // Пример массива символов
        string str = CreateString(charArray); // Создание строки из массива символов с помощью функции
        Console.WriteLine(str); // Вывод строки
    }

    static string CreateString(char[] charArray)
    {
        return new string(charArray); // Создание строки из массива символов
    }
}