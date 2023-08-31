﻿/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

456 - 3
78 - 2
89126 - 5
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

Console.WriteLine($"в числе {userNumber} - {Quantity(userNumber)} символов");