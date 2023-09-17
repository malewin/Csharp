/*
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

//задаём двумерный массив
int[,] Get2DArray()
{
    Console.Write("Введите количество столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

//выводим на экран думерный массив
void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// конвертация двумерного массива в одномерный 
int[] ExpandMatrix(int[,] matrix)
{
int n = matrix.GetLength(0) * matrix.GetLength(1);
int[] array = new int[n];
n = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
array[n] = matrix[i, j];
n++;
}
}
return array;
}

// Сортировка элементов в одномерном массиве по возрастанию
int [] CollectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i + 1; j < array.Length; j++)
{
if (array[j] < array[minPosition]) minPosition = j;
}
if (i != minPosition)
{
int tmp = array[i];
array[i] = array[minPosition];
array[minPosition] = tmp;
}
}
return array;
}

//выводим на экран отсортированный одномерный массив
void PrintArray(int [] arrayToPrint)
{
    Console.Write($"[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.Write($"]");
}

/* делаем так, чтобы пока значение текущего индекса равно 
значению переменной присвоенного из этого индекса мы крутим счетчик, иначе
присваиваем переменной значение следующего индекса отличного от того на котором остановились.*/
void Searcher(int[] array)
{
    int temp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == temp) count++;
        else
        {
            Console.WriteLine($"Число {temp} встречается в массиве {count} раз");
            temp = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
            Console.WriteLine($"Число {temp} встречается в массиве {count} раз");
    }
}



int [,] array2D = Get2DArray();
Print2DArray(array2D);
PrintArray(CollectionSort(ExpandMatrix(array2D)));
Console.WriteLine();
Searcher(CollectionSort(ExpandMatrix(array2D)));



