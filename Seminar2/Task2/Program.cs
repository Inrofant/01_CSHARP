// Напишите программу, которая принимает на вход 
// трёхзначное число и возводит вторую цифру этого числа в степень, 
// равную третьей цифре.

// int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(10,1500);
Console.WriteLine(num);
if(num < 1000 && num > 99)
{
    int num_3 = num % 10;
    int num_2 = num / 10 % 10; //123 /10 ->12 %10 ->2 
    Console.WriteLine(Math.Pow(num_2, num_3));

}
else
{
    Console.WriteLine("число не трехзначное");
}