/*
Задайте двумерный массив из целых чисел. Найдите среднее
арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] MidAriphm(int[,] userArray)
{
    double[] result = new double[userArray.GetLength(1)];
    for (int i = 0; i < userArray.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < userArray.GetLength(0); j++)
        {
            summ = summ + userArray[j, i];
        }
        result[i] = summ / userArray.GetLength(0);
    }
    return result;
}

void PrintResult(double [] arrayToPrint)
{
    Console.Write("[Avg]\t");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i], 1));
        if (i < arrayToPrint.Length -1) System.Console.Write("\t");
    }
}

int [,] array2D = Get2DArray();
double [] results = MidAriphm(array2D);
Print2DArray(array2D);
PrintResult(results);