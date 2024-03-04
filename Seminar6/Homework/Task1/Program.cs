// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив символов
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o',},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Создаем строку из символов массива
        string result = CreateString(charArray);

        // Выводим строку на экран
        Console.WriteLine("Строка из массива:");
        Console.WriteLine(result);
    }

    // Функция для создания строки из двумерного массива символов
    static string CreateString(char[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);
        char[] charArray = new char[rowCount * colCount]; // Создаем одномерный массив символов

        int index = 0;
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                charArray[index] = array[i, j]; // Заполняем одномерный массив символов
                index++;
            }
        }

        // Создаем строку из символов массива
        string result = new string(charArray);
        return result;
    }
}
