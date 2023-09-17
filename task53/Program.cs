/*
Задайте двумерный массив. Напишите программу, которая 
поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
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
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int [,] ResultArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int temp = 0;

    for (int i = 0; i < cols; i++)
    {
        temp = array[0, i];
        array[0, i] = array[rows-1, i];
        array[rows-1, i] = temp;
    }
    return array;
}
int [,] arr = Get2DArray();
Print2DArray(arr);
Console.WriteLine();
int [,] arr2 = ResultArray(arr);
Print2DArray(arr2);
