/*
Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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


void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1 ; i++)
  {
    int minPosition = i;
    
    for (int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition]) minPosition = j; 
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}


int [,] Sort2DArray (int [,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int [,] resultArray = new int [rows, cols];
    for (int i = 0; i <= rows-1; i++)
    {
        int [] maxPosR = [i, j];
        for (int j = i + 1 ; j < rows; j++)
        {
            if(array[j] > array[maxPosR]) maxPosR = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosR];
        array[maxPosR] = temporary;
        for (int k = 0; k <= cols-1; k++)
        {
            int maxPosC = k;
            for (int m = k + 1; m < cols; m++)
            {
               if 
            }
        }
    }
    return resultArray;
}