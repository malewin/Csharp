﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее,а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
Дополнительно: + учитывает если числа равны
*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Наибольшеe число: max=" + number1);
    Console.WriteLine("Наименьшее число: min=" + number2);
}
else
if (number1 < number2)                                     // пришлось добавить чтобы в третьем случае с равенством не было лишнего текста
{
    Console.WriteLine("Наибольшеe число: max=" + number2);
    Console.WriteLine("Наименьшее число: min=" + number1);
}
else                                                       // иначе тут были проблемки с синтаксисом
if(number1 == number2)
{
    Console.WriteLine("Числа равны");
}
