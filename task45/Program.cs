/*
Напишите программу, которая будет создавать копию заданного одномерного массива
с помощью поэлементного копирования
*/

int [] array = {1, 2, 3, 4, 5};

int [] copyArray(int[] array)
{
    int[] copyarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyarray[i] = array[i];
    }
    return copyarray;
}

int [] copyarray1 = copyArray(array);

void PrintUserArray(int [] userArray)
{
    Console.Write($"[");
    for (int i = 0; i < (userArray.Length - 1); i++)
    {
      Console.Write($" {userArray[i]},");
    }
    for (int j = (userArray.Length - 1); j < userArray.Length; j++)
        {
            Console.Write($" {userArray[j]}");
        }
    Console.Write($" ]");
    Console.WriteLine("");
}

Console.WriteLine($"Ваш изначальный массив: ");
PrintUserArray(array);
Console.WriteLine($"Ваш клонированный массив: ");
PrintUserArray(copyarray1);
