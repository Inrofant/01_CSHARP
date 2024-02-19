// Напишите программу, которая принимает на вход  
// трёхзначное число и удаляет вторую цифру этого числа.


using Internal;

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int s = num/100*10 + num%10;
Console.WriteLine(s);
