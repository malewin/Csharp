/* Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> max = 7
44, 5, 78 -> max = 78
22, 3, 9 -> max = 9
Дополнительно: + выдаёт минимальное из трёх чисел.
*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number1;

if(number1 > number2 && number1 > number3 && number2 > number3) // первое больше обоих, второе больше третьего
{
    Console.WriteLine("Максимальное число: " + max);
    min = number3;
    Console.WriteLine("А минимальное число: " + min);
}
else
if(number1 > number2 && number1 > number3 && number2 < number3) // первое больше обоих, третье больше второго
{
    Console.WriteLine("Максимальное число: " + max);
    min = number2;
    Console.WriteLine("А минимальное число: " + min);
}
else
if(number1 > number2 && number1 < number3) // третье больше обоих, первое больше второго
{
    max = number3;
    Console.WriteLine("Максимальное число: " + max);
    min = number2;
    Console.WriteLine("А минимальное число: " + min);
}
else
if(number1 < number2 && number1 < number3 && number3 > number2) // третье больше обоих, второе больше первого
{
    max = number3;
    Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("А минимальное число: " + min);
}
else
if(number1 < number2 && number1 > number3) // второе больше обоих, первое больше третьего
{
    max = number2;
    Console.WriteLine("Максимальное число: " + max);
    min = number3;
    Console.WriteLine("А минимальное число: " + min);
}
else
if(number1 < number2 && number1 < number3 && number2 > number3) // второе больше обоих, третье больше первого
{
    max = number2;
    Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("А минимальное число: " + min);
}