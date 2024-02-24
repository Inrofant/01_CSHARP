// int n = 10;
// int[] arr = new int[n];
// FillArray(arr);
// PrintArray(arr);
// int sum = GetSumOfElements(arr);
// int product = GetProductOfElements(arr);
// Console.WriteLine($"Сумма элементов массива: {sum}");
// Console.WriteLine($"Произведение элементов массива: {product}");


        int n = 10;
        int[] arr = new int[n];
        FillArray(arr);
        PrintArray(arr);
        int sum = GetSumOfElements(arr);
        int product = GetProductOfElements(arr);
        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Произведение элементов массива: {product}");


void FillArray(int[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 101);
        }
    }

void PrintArray(int[] array)
    {
        Console.WriteLine("Элементы массива:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

int GetSumOfElements(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

int GetProductOfElements(int[] array)
    {
        int product = 1;
        foreach (int num in array)
        {
            product *= num;
        }
        return product;
    }
