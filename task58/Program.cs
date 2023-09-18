/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[,] FillMatrix1()
{
    Console.Write("Введите количество столбцов 1-ой матрицы: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк 1-ой матрицы: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение 1-ой матрицы: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение 1-ой матрицы: ");
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

int[,] FillMatrix2(int rows)
{
    Console.Write("Введите количество столбцов 2-ой матрицы: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение 2-ой матрицы: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение 2-ой матрицы: ");
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

int [,] ScalarMultiplicationOMatrixElements(int [,] matrix1, int [,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    int [,] readyMatrix = new int[rows1, cols2];
    int multiplicProduct = 1;

    for (int i = 0; i < rows1; i++)
    {
        for (int m = 0; m < cols2; m++)
        {
            for (int j = 0; j < cols1; j++)
            {
                for (int n = 0; n < rows2; n++)
                {
                  multiplicProduct = matrix1[i, j] * matrix2[n, m];
                  readyMatrix[i, m] += multiplicProduct;
                }
            }
        }
    }
    return readyMatrix;
}

int [,] matrix1 = FillMatrix1();
int rows = matrix1.GetLength(1);
int [,] matrix2 = FillMatrix2(rows);
int [,] readyMatrix = ScalarMultiplicationOMatrixElements(matrix1, matrix2);

Print2DArray(matrix1);
Console.WriteLine();
Print2DArray(matrix2);
Console.WriteLine();
Print2DArray(readyMatrix);

//подправить