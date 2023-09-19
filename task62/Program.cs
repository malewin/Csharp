/*
Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int [,] SpiralMethod()
{
    int rows = 4;
    int cols = 4;
    int [,] array = new int [rows, cols];
    int value = 1;
    //границы массива
    int left = 0, right = cols-1, top = 0, bottom = rows-1;

    while(left <= right && top <= bottom)
    {
       //верхняя строка слева направо
       for (int i = left; i <= right; i++)
        array[top, i] = value++;
       //правый столбец сверху вниз
       for (int j = top + 1; j <=bottom; j++)
        array[j, right] = value++;
       //нижняя строка справа налево
       if (top < bottom)
       {
       for (int i = right-1; i >= left; i--)
        array[bottom, i] = value++;
       }
       //левый столбец снизу вверх
       if (left < right)
       {
        for (int i = bottom - 1; i > top; i--)
        array[i, left] = value++;
       }
       left++;
       right--;
       top++;
       bottom--;
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

Print2DArray(SpiralMethod());