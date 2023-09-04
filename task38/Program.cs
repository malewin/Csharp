/*
Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементом массива.
*/

Console.WriteLine("Введите количество эдементов в массиве:");
int arrayL = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел диапазона чисел массива:");
double minBorder = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите верхний предел диапазона чисел массива:");
double maxBorder= Convert.ToDouble(Console.ReadLine()) + 1;

double [] GetRandomArray(int arrayL, double minBorder, double maxBorder)
{
    double [] array1 = new double [arrayL];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i]= new Random().NextDouble() * (maxBorder - minBorder) + minBorder;
    }
    return array1;
}
double [] userArray = GetRandomArray(arrayL, minBorder, maxBorder);

void PrintUserArray(double [] userArray)
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

double SortOfMinMaxAndCountOfDifference(double[] array)
{
  for (int i = 0; i < array.Length - 1 ; i++)
  {
    int minPosition = i;
    
    for (int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition]) minPosition = j; 
    }
    double temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
  double difference = array[array.Length - 1] - array [0];
  return difference;
}
double differenceOfMaxMinElements = SortOfMinMaxAndCountOfDifference(userArray);

void PrintDifference(double difference)
{
    Console.WriteLine("");
    Console.WriteLine($"Разница между максимальным и минимальным элементом в нём равна {difference}");
}

PrintUserArray(userArray);
PrintDifference(differenceOfMaxMinElements);