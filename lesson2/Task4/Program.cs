﻿// Дано N гирь с разным весом в случайном
// порядке. Определить вес самой тяжелой гири.

int n = 5;
int[] array = { 20, 4, 7, 3, 9 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

///для перебора по элементам массива, верхняя граница числа итераций не изветна
//for (int i=0; - инициализация i < 10; - условие i = i+1 - модификация)
//{
    ///...
//}


max = array[0];
for(int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);

///для перебора по элементам массива, без использования индекса и изменения, только чтение
//foreach (int e in array)
//{
    //console.write(e);
//}
max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);