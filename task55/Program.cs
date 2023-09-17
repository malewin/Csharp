/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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

int [,] ChangesStringsAndColumns (int [,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
           temp = matrix[i, j];
           matrix[i, j] = matrix [j, i];
           matrix[j, i] = temp;
        }
        
    }
    return matrix;
}

int [,] userMatrix = Get2DArray();
Print2DArray(userMatrix);
Console.WriteLine();
Print2DArray(ChangesStringsAndColumns(userMatrix));
