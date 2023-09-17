/*
Задайте двумерный массив из целых чисел. Напишите программу, которая 
удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 
25 9 2 
38 4 2 
45 2 6 7Наименьший элемент - 1, на выходе получим следующий массив: 9 4 22 2 63 4 7
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

//выводим на экран думерный массив
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

int [] CoordMinValue (int [,] array)
{
    int [] result = new int [2];
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if(array[i,j] < min) 
        {
            min = array[i, j];
            result[0] = i;
            result [1] = j;
        }
      }  
    }
    return result;
}

int [,] FillZero(int [,] array, int [] coords)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[coords[0], i] = 0;
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
       array[i, coords[1]] = 0 ;
    }
    return array;
}

/*
int [,] DeleteCross( int [,] filledArray, int [] coords)
{
    int rows = filledArray.GetLength(0) - 1;
    int cols = filledArray.GetLength(1) - 1;
    int [,] arrayWithoutCross = new int[rows, cols];
    int rowArrayWithoutCross = 0;
    int colArrayWithoutCross = 0;
    for (int i = 0; i < rows; i++)
    {
        if (i == coords[0]) continue;
        else
        for (int j = 0; j < cols; j++)
        {
        if (j == coords[1]) continue;
        else
        {
         arrayWithoutCross[rowArrayWithoutCross, colArrayWithoutCross] = filledArray[i, j];
         colArrayWithoutCross++;
        }
        }
        rowArrayWithoutCross++;
        colArrayWithoutCross = 0;
    }
    return arrayWithoutCross;
} */

int [,] DeleteCross( int [,] filledArray, int [] coords)
{
    int rows = filledArray.GetLength(0) - 1;
    int cols = filledArray.GetLength(1) - 1;
    int [,] arrayWithoutCross = new int[rows, cols];
    int rowArrayWithoutCross = 0;
    int colArrayWithoutCross = 0;
    for (int i = 0; i <= rows; i++)
    {
        if (i == coords[0]) continue;
        else
        for (int j = 0; j <= cols; j++)
        {
        if (j == coords[1]) continue;
        else
        {
         arrayWithoutCross[rowArrayWithoutCross, colArrayWithoutCross] = filledArray[i, j];
         colArrayWithoutCross++;
        }
        }
        rowArrayWithoutCross++;
        colArrayWithoutCross = 0;
    }
    return arrayWithoutCross;
}

int [,] arr = Get2DArray();
Print2DArray(arr);
Console.WriteLine();
Print2DArray(FillZero(arr, (CoordMinValue(arr))));
Console.WriteLine();
Print2DArray(DeleteCross(arr, (CoordMinValue(arr))));
