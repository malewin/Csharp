/* Напишите програму, котоаря принимает на вход трёхзначное число
и на выходе показывает по следнюю цифру этого числа */

Console.WriteLine("Введите трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последняя цифра: "+ number%10);


