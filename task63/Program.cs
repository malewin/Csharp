/*
Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
*/

void NaturalNumb (int n, int start = 1)
{
   if (start <= n)
   {
    Console.Write(start + ", ");
    NaturalNumb(n, start + 1);
   }
}

NaturalNumb(5);