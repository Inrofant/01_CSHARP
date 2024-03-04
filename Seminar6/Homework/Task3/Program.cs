// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "level"; // Произвольная строка
        
        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(input);
        
        // Выводим результат
        if (isPalindrome)
            Console.WriteLine("Строка является палиндромом.");
        else
            Console.WriteLine("Строка не является палиндромом.");
    }

    // Функция для проверки строки на палиндром
    static bool IsPalindrome(string str)
    {
        // Приводим строку к нижнему регистру для удобства сравнения
        str = str.ToLower();

        int left = 0;
        int right = str.Length - 1;

        // Продолжаем сравнивать символы с обоих концов строки
        while (left < right)
        {
            // Если символы не совпадают, строка не является палиндромом
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        // Если все символы совпали, строка является палиндромом
        return true;
    }
}
