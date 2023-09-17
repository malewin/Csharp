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

int[,] Sort2DArray(int[,] array)
{
    bool sortIsCompleted;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    do
    {
        sortIsCompleted = false;
        for (int i = 0; i < rows; i++) // начало для строк
        {
            for (int j = 1; j < cols; j++) // начало для столбцов
            {
                
                if (array[i, j - 1] < array[i, j]) 
                {
                int temporary = array[i, j - 1];
                array[i, j - 1] = array[i, j];
                array[i, j] = temporary;
                sortIsCompleted = true;
                }
            }
        }
    } while (sortIsCompleted);
        return array;
}

int [,] userArray = Get2DArray();
Print2DArray(userArray);
Console.WriteLine();
int [,] sort2DArray = Sort2DArray(userArray);
Print2DArray(sort2DArray);