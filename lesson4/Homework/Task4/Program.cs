// считать строку из букв и цифр, как и в решенной ранее
// задаче. Далее необходимо выбрать из этой строки цифры и сформировать из них
// массив.

using System;

class Program
{
    static int[] GetDigitsArray(string s)
    {
        int[] digitsArray = new int[s.Length];
        int index = 0;
        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                digitsArray[index++] = int.Parse(c.ToString());
            }
        }
        Array.Resize(ref digitsArray, index); // Обрезаем массив до реального размера
        return digitsArray;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку, содержащую буквы и цифры:");
        string str = Console.ReadLine()!;
        int[] digits = GetDigitsArray(str);
        
        Console.WriteLine("Цифры, обнаруженные в строке:");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }
    }
}
