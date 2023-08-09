/* Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
while (number > 999)
{
    number = number / 10;
}
if (number <= 999 && number > 99)
{
    int thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра - {thirdNumber}");
}
else
{
   Console.WriteLine("Третьей цифры - нет"); 
}
