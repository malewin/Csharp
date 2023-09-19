/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] FillUniqueRandom3DArray ()
{
    Console.WriteLine("Введите кол-во столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите глубину массива: ");
    int deep = Convert.ToInt32(Console.ReadLine());
    int [,,] array = new int[cols, rows, deep];
    Console.WriteLine("Введите минимальное значение диапазона: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение диапазона: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    if (maxValue - minValue < rows * cols * deep) Console.WriteLine("в массиве больше ячеек, чем уникальных элементов");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
           for (int j = 0; j < array.GetLength(1); j++)
           {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                bool haveRepeat;
                int randomValue = 0;
                do
                {
                  haveRepeat = false;
                  randomValue = new Random().Next(minValue, maxValue);
                  foreach (var item in array)
                  {
                    if (item == randomValue) haveRepeat = true;
                  }
                } while (haveRepeat);
                array[i, j, k] = randomValue;
            }
           } 
        }
    }
    return array;
}

void Print3DArray(int [,,] arrayForPrint)
{
     for (int i = 0; i < arrayForPrint.GetLength(0); i++)
        {
           for (int j = 0; j < arrayForPrint.GetLength(1); j++)
           {
            for (int k = 0; k < arrayForPrint.GetLength(2); k++)
            {
               Console.WriteLine($"array[{i}, {j}, {k}] = {arrayForPrint[i, j, k]}");
            }
           } 
        }
}

int [,,] userArray = FillUniqueRandom3DArray();
Print3DArray(userArray);