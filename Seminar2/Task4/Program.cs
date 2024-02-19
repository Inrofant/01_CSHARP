// Напишите программу, которая выводит 
// третью слева цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// num < 100 -> третьей цифры нет
// num = 5789  / 10
// num = 578

int num2 = 0;
if(num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num /= 10; //num / 10
    }
    num2 = num % 10;
    Console.WriteLine(num2);
}
