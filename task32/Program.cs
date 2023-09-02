/*
Напишите программу замены элементов массива: отрицательные на положительные, положительные на отрицательные
*/


Console.WriteLine("Введите количество эдементов в массиве:");
int arrayL = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел диапазона чисел массива:");
int minBorder = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел диапазона чисел массива:");
int maxBorder= Convert.ToInt32(Console.ReadLine()) + 1;

int [] GetRandomArray(int arrayL, int minBorder, int maxBorder)
{
    int [] array1 = new int [arrayL];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i]= new Random().Next(minBorder,maxBorder);
    }
    return array1;
}

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
}

int[] ChangeSignArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

int [] userArray = GetRandomArray(arrayL, minBorder, maxBorder);
Console.Write("Ваш первоначальный массив:");
PrintUserArray(userArray);
Console.WriteLine("");
Console.Write("Ваш изменённый массив:");
int [] returnArray = ChangeSignArray(userArray);
PrintUserArray(returnArray);
