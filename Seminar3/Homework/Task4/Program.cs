// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе 
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.



using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим натуральное число
        Console.Write("Введите натуральное число от 1 до 100000: ");
        int number = int.Parse(Console.ReadLine());

        // Определяем количество цифр в числе
        int digitCount = (int)Math.Floor(Math.Log10(number)) + 1;

        // Создаем массив для хранения цифр числа
        int[] digits = new int[digitCount];

        // Заполняем массив цифрами числа
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        // Выводим массив на экран
        Console.WriteLine("Массив цифр числа:");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }
    }
}