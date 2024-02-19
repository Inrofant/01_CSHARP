// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.



int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 % num2 != 0)
{
    Console.WriteLine($"число {num2} не является кратным {num1}! Остаток от деления: {num1 % num2}");
}
else
{
    Console.WriteLine($"Число {num2} является кратным {num1}!");
}