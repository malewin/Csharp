/* Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> max = 7
44, 5, 78 -> max = 78
22, 3, 9 -> max = 9
*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number1 > number2 && number1 > number3)
{
    Console.WriteLine("Максимальное число: " + max);
}
else
if(number1 > number2 && number1 < number3)
{
    max = number3;
    Console.WriteLine("Максимальное число: " + max);
}
else
if(number1 < number2 && number1 > number3)
{
    max = number2;
    Console.WriteLine("Максимальное число: " + max);
}