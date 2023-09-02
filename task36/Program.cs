/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов стоящих на нечётных позициях.
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

int SumOfNechentElement (int [] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            summ = summ + array[i];
        }
    }
    return summ;
}
int summNechetn = SumOfNechentElement(userArray);

void PrintSummNechent ()
{
    Console.WriteLine("");
    Console.WriteLine($"Сумма элементов на начётных позициях в нём равна {summNechetn}");
}

PrintUserArray(userArray);
PrintSummNechent();