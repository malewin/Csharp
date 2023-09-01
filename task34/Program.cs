﻿/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] Random3symbolArray()                         // "метод автозаполнения" рандомными 3-значными элементами массива
{
    int [] array = new int [8];                    // в скобках можете поменять количество элементов массива
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(100,1000);
    }
    return array;
}

int [] readyArray = Random3symbolArray();          //задаем переменную массива с помощью "метода автозаполнения"

void PrintRandomArray(int [] printArray)          // "метод индикации" сгенерированного масиива
{
    Console.Write($"Ваш массив: [");
    for (int i = 0; i < (printArray.Length - 1); i++)
    {
      Console.Write($" {printArray[i]},");
    }
    for (int j = (printArray.Length - 1); j < printArray.Length; j++)
        {
            Console.Write($" {printArray[j]}");
        }
    Console.Write($"]");
}

int ChetnyiCounter (int [] chetnArray)            // "метод анализа и счета" количества четных элементов
{
    int counter = 0;                               // наш счётчик количества чётных элементов
    for (int i = 0; i < chetnArray.Length; i++)   //перебираем индексы элементов массива
    {
        if(chetnArray[i] % 2 == 0)                 // если при делении элемента на 2 в остатке 0 значит чётное число
        {
            counter++;                             // и мы прибавляем к счетчику количество таких чисел по одному
        }
    }
    return counter;
}

int counter1 = ChetnyiCounter(readyArray);         // задаём переменную счётчика с помощью "метода анализа и счёта"

void PrintChetnValues(int counter2)                // "метод вывода на печать" переменной счётчика
{
    Console.WriteLine($". В нём - {counter2} чётных элементов");
}

PrintRandomArray(readyArray);
PrintChetnValues(counter1);



