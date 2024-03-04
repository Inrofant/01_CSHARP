// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.

// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

using System;

class Program

{
    static void Main(string[] args)
    {
        string str = "Hello!"; // Исходная строка
        char[] charArray = StringToCharArray(str); // Преобразование строки в массив символов
        PrintCharArray(charArray); // Вывод массива символов на экран
    }

    static char[] StringToCharArray(string str)
    {
        char[] charArray = new char[str.Length]; // Создание массива символов заданной длины
        for (int i = 0; i < str.Length; i++)
        {
            charArray[i] = str[i]; // Заполнение массива символов символами из строки
        }
        return charArray; // Возврат массива символов
    }

    static void PrintCharArray(char[] charArray)
    {
        Console.Write("[");
        for (int i = 0; i < charArray.Length; i++)
        {
            Console.Write("'" + charArray[i] + "'");
            if (i < charArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
    
}