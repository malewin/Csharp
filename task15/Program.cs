﻿/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int[] vyhodnye = { 6, 7 };
Console.Write("Введите цифру дня недели (1-понедельник; 7- воскресенье): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
{
    bool etoVyhi = false;
    for (int i = 0; i < vyhodnye.Length; i++)
    {
        if (vyhodnye[i] == number)
        {
            etoVyhi = true;
            break;
        }
    }
    if (etoVyhi) {Console.WriteLine("Это выходной");}
    else {Console.WriteLine("Это будний день");}
}
else
{
    Console.WriteLine("Такого дня недели нет");
}
