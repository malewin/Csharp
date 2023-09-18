/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] Get2DArray()
{
    Console.Write("Введите количество столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SearchMinSumRow(int[,] userArray)
{
    int[] arrayOfSum = new int[userArray.GetLength(0)];
    int sum = 0;
    int cloneOfSum = 0;
    for (int i = 0; i < userArray.GetLength(0); i++)
    {   
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            sum = userArray[i, j] + sum;
        }
        cloneOfSum = sum;
        sum = 0;
        arrayOfSum[i] = cloneOfSum;
    }
    return arrayOfSum;
}

void PrintArray(int [] arrayToPrint)
{
    Console.Write($"[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.Write($"]");
}


void PrintAnswer(int [] arrayForAnalytics)
{
    int min = arrayForAnalytics[0];
    int stringNumber = 0;
    for (int i = 1; i < arrayForAnalytics.Length ; i++)
    {
        if (min > arrayForAnalytics[i])
        {
        min = arrayForAnalytics[i];
        stringNumber = (i);
        }
    }
   Console.WriteLine($"В {stringNumber} строке минимальная сумма элементов равная {min}"); 
}





int [,] arr = Get2DArray();
Print2DArray(arr);
Console.WriteLine();
PrintArray(SearchMinSumRow(arr));
Console.WriteLine();
PrintAnswer(SearchMinSumRow(arr));