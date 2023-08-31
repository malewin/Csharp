/*
Напишите программу, которая выодит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке
*/
/*
void PrintArray()
{
    Console.WriteLine(GetRandomArray);
}
*/

int [] GetRandomArray()
{
    int [] array1 = new int [8];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i]= new Random().Next(0,2);
    }
    return array1;
}

int [] userArray = GetRandomArray();

void PrintArray(int [] arrayToPrint)
{
    Console.Write($"[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.Write($"]");
}

PrintArray(userArray);