/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат
(число умноженное само на себя)


4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;
Console.WriteLine(result);
