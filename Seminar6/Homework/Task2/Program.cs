// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Исходная строка с латинскими буквами в обоих регистрах
        string inputString = "Hello World!";

        // Формируем новую строку, в которой все заглавные буквы заменены на строчные
        string resultString = ConvertToUpperToLower(inputString);

        // Выводим результат на экран
        Console.WriteLine("Строка с заменой заглавных букв на строчные:");
        Console.WriteLine(resultString);
    }

    // Функция для замены всех заглавных букв на строчные в строке
    static string ConvertToUpperToLower(string str)
    {
        // Создаем пустую строку, в которую будем добавлять символы
        string result = "";

        // Проходим по каждому символу входной строки
        foreach (char ch in str)
        {
            // Если символ является заглавной буквой, заменяем его на строчную
            if (char.IsUpper(ch))
            {
                result += char.ToLower(ch);
            }
            else
            {
                // Если символ не является заглавной буквой, оставляем его без изменений
                result += ch;
            }
        }

        // Возвращаем полученную строку
        return result;
    }
}
