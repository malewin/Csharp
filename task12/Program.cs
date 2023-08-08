/* Напишите программу, которая будет принимать на вход два числа и выводить
является ли второе число кратно первому. Если второе число не кратно первому, 
то программа выводит остаток от деления
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.Writeline("Введите первое число")
int number1 = Convert.ToInt32(Console.Readline());
Console.Writeline("Введите второе число")
int number2 = Convert.ToInt32(Console.Readline());
int ostatok = number1 % number2;

if(number1 % number2 = 0 && number2 % number1 = 0)
{
    Console.Writeline("Числа кратны");
}
else
{
    Console.WriteLine(ostatok);
}