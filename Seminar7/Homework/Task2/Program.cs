// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

//пример m = 2, n = 3 -> A(m,n) = 29

using System;

class Program
{
    static int InputNumber(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        int m = InputNumber("Введите число m: ");
        int n = InputNumber("Введите число n: ");

        Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");
    }

    static int AckermannFunction(int m, int n)
    {
        while (true)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                n = 1;
                m--;
            }
            else
            {
                int tempN = AckermannFunction(m, n - 1);
                m--;
                n = tempN;
            }
        }
    }
}



