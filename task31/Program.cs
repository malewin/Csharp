/* 
Задайте массив из 12 элементов, заполенный случайными числами из промежутка [-9; 9].
Найдите сумму отрицательных и положительных элементов массива.
*/

int [] GetRandomArray()
{
    int [] array1 = new int [12];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i]= new Random().Next(-9,10);
    }
    return array1;
}

int [] readyArray = GetRandomArray();

int SumPolozh(int [] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 0)
        {
            result = result + array1[i];
        }
    }
    return result;
}

int SumOtric(int [] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < 0)
        {
            result = result + array1[i];
        }
    }
    return result;
}

void PrintArrayAndResults(int [] printArray)          
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
    Console.WriteLine($"]");
    Console.WriteLine($"Сумма положительных элементов в нём равна {SumPolozh(readyArray)}");
    Console.WriteLine($"Сумма отрицательных элементов в нём равна {SumOtric(readyArray)}");
}

PrintArrayAndResults(readyArray);