/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
последний элементы массива, второй и предпоследний и т д.
Результат запишите в новом массиве
*/

Console.WriteLine("Введите количество элементов в массиве:");
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
int [] NewArrayFromProizvPairElements (int [] array)
{
    if (arrayL % 2 == 0)
    {
        int[] newArray = new int[(arrayL / 2)];
        int proizvOfPair = 0;
        int nextEndIndex = array.Length - 1;
        for (int i = 0; i < array.Length / 2; i++)
        {
            proizvOfPair = array[i] * array[nextEndIndex];
            newArray[i] = proizvOfPair;
            nextEndIndex--;
        }
        return newArray;
    }
    else
    {
        int[] newArray = new int[(arrayL / 2) + 1];
        int proizvOfPair = 0;
        int nextEndIndex = array.Length - 1;
        for (int i = 0; i <= nextEndIndex; i++)
        {
            if(i == nextEndIndex)
            {
                newArray[i] = array[i];
            }
            else
            {
            proizvOfPair = array[i] * array[nextEndIndex];
            newArray[i] = proizvOfPair;
            nextEndIndex--;
            }
        }
        return newArray;
    }
}
int [] newArray = NewArrayFromProizvPairElements(userArray);

void PrintNewArray ()
{
    Console.WriteLine("");
    Console.WriteLine($"Ваш новый массив из попарных произведений: {newArray}");
}
PrintUserArray(userArray);
PrintNewArray();