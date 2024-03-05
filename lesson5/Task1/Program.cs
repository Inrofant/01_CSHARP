// Вычислить факториал от натурального
// числа N

// int Fact(int n)
// {
//     if (n == 1 || n == 0)
//     {
//         Console.WriteLine($"Stop: {n}");
//         return 1;
//     }
//     Console.WriteLine($"Call: {n}");
//     return n * Fact(n - 1);
// }

// Console.Write(Fact(5));

// //1 для демонстрации (оптимальней for)

using System;

class Program
{
    // Вычислить факториал от натурального числа N
    static int Fact(int n)
    {
        // Базовый случай: если n равно 1, то возвращаем 1 и завершаем рекурсию
        if (n == 1 || n == 0)
        {
            Console.WriteLine($"остановка: n={n}");
            return 1;
        }
        
        // Рекурсивный случай: если n не равно 1, выполняем следующие действия
        Console.WriteLine(n);

        // Рекурсивный вызов функции Fact с аргументом (n - 1) и умножение результата на n
        int result = n * Fact(n - 1);

        // Выводим информацию о возврате значения из рекурсивного вызова
        Console.WriteLine($"Возврат: n={n}, fact={result}");
        
        // Возвращаем результат рекурсивного вызова
        return result;
    }

    static void Main(string[] args)
    {
        // Выводим результат вызова функции Fact с аргументом 5
        Console.Write(Fact(5));
    }
}

