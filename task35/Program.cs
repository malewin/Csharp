/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке значений [10, 99]
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
int [] userArray = GetRandomArray(arrayL, minBorder, maxBorder);

void PrintUserArray(int [] userArray)
{
    Console.Write($"Ваш массив: [");
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

int CounterOfElementsInValueRange (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}
int count = CounterOfElementsInValueRange(userArray);

void PrintCount ()
{
    Console.WriteLine("");
    Console.WriteLine($"В нём {count} элементов в диапазоне значений от 10 до 99 (включительно).");
}

PrintUserArray(userArray);
PrintCount();