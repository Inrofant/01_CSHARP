﻿// Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23


Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}