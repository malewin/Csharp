/*
Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumOfSymbolsBetweenNumbers(int m, int n)
{
    int sum = 0;
    if (m <= n)
    {
        sum = m + SumOfSymbolsBetweenNumbers(m + 1, n);
    }
    return sum;
}

int result = SumOfSymbolsBetweenNumbers(m, n);
Console.WriteLine(result);

