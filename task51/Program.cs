/*
Задайте двумерный массив. Найдите сумму элементов, находящихся 
на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] Get2DArray(int cols, int rows, int min, int max)
{
    int[,] array = new int[cols, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
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

int SumDioganal(int[,] array)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i<rows; i++)
    {
        for (int j = 0; j<cols; j++)
        {
            if (i == j) sum = sum + array[i,j];
        }
    }
    return sum;
}

int [,] arr = Get2DArray(8, 8, 1, 20);
Print2DArray(arr);
Console.WriteLine($"Сумма элементов центральной диагонали массива равна: {SumDioganal(arr)} ");