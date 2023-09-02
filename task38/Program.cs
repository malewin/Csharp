/*
Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементом массива.
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

int SortOfMinMaxAndCountOfDifference(int[] array)
{
  for (int i = 0; i < array.Length - 1 ; i++)
  {
    int minPosition = i;
    
    for (int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition]) minPosition = j; 
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
  int difference = array[array.Length - 1] - array [0];
  return difference;
}
int differenceOfMaxMinElements = SortOfMinMaxAndCountOfDifference(userArray);

void PrintDifference(int difference)
{
    Console.WriteLine("");
    Console.WriteLine($"Разница между максимальным и минимальным элементом в нём равна {difference}");
}

PrintUserArray(userArray);
PrintDifference(differenceOfMaxMinElements);