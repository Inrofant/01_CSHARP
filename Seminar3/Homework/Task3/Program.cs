﻿// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 


using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Задаем массив из вещественных чисел
        double[] array = { 3.5, 7.2, 1.8, 9.6, 4.3 };

        // Находим минимальный и максимальный элементы массива
        double min = array.Min();
        double max = array.Max();

        // Вычисляем разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Выводим результат
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
    }
}