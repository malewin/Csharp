/*
Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
void NaturalNumb (int n ,int finish = 1)
{
   if (finish <= n-1)
   {
    Console.Write((n - 1) + ", ");
    NaturalNumb((n - 1), finish);
   }
}

NaturalNumb(n);
