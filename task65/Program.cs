/*
65. Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
*/

void NaturalNumb (int m, int n)
{
   if (m <= n)
   {
    Console.Write(m+ ", ");
    NaturalNumb(m + 1, n);
   }
}

NaturalNumb(1, 10);