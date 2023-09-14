﻿/*
Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] Get2DArray(int cols, int rows, int deviation)
{
    int[,] array = new int[cols, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation);
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

void Searcher(int [,] array2D)
{
    Console.Write("Введите номер строки искомого элемента массива: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца искомого элемента массива: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < array2D.GetLength(0) && j < array2D.GetLength(1)) Console.WriteLine($"Ваш искомый элемент: {array2D[i, j]}");
    else Console.WriteLine("Такого элемента нет");
}

int [,] ourArray = Get2DArray(5,5,19);
Print2DArray(ourArray);
Searcher(ourArray);