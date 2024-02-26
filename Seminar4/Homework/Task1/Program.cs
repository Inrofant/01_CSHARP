// Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целые числа. Для выхода введите 'q' или число с четной суммой цифр.");

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine()!;

            // Проверяем, является ли ввод символом 'q' для выхода
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Пытаемся преобразовать введенную строку в число
            if (int.TryParse(input, out int number))
            {
                // Проверяем, четна ли сумма цифр числа
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }
    }

    // Функция для проверки, является ли сумма цифр числа четной
    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        number = Math.Abs(number); // Убираем знак минус, если есть
        while (number > 0)
        {
            sum += number % 10; // Получаем последнюю цифру числа и добавляем ее к сумме
            number /= 10; // Убираем последнюю цифру числа
        }
        return sum % 2 == 0; // Проверяем, является ли сумма четной
    }
}