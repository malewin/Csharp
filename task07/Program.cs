/* Напишите програму, котоаря принимает на вход трёхзначное число
и на выходе показывает по следнюю цифру этого числа */

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>99 && number<1000)
{
Console.WriteLine("Последняя цифра: "+ number%10);
}

