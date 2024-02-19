// Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

Console.Write("Введите двузначное число (от 10 до 99): ");
int number = int.Parse(Console.ReadLine()!);
// Проверяем, что число находится в допустимом диапазоне
if (number < 10 || number > 99)
{
Console.WriteLine("Число должно быть от 10 до 99.");
return;
}

// Находим наибольшую цифру в числе
int firstDigit = number / 10;
int secondDigit = number % 10;
int maxDigit = Math.Max(firstDigit, secondDigit);

// Выводим результат
Console.WriteLine($"Наибольшая цифра в числе {number} равна {maxDigit}.");