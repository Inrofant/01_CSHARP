// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.

// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


int[] Random_mas(int num)
{
    int[] mas = new int[num];
    for (int i = 2; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 21);
    }
    return mas;
}

void Print_mas(int[] mas)
{
    foreach (var i in mas)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

bool prost(int num)
{
    if(num == 0 || num == 1) return false;
    else
    {
        for (int i = 2; i < num; i++)
        {
            if(num % i == 0) return false;
        }
        return true;
    }
}

int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if(prost(i))
        {
            Console.Write($"{i} ");
            count ++;
        }
    }
    Console.WriteLine();
    return count;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = Random_mas(n);
Print_mas(arrey);
Console.WriteLine(Count(arrey));
Console.WriteLine(prost(7));
