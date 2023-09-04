

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
    Console.WriteLine("");
}

int [] TurnArray(int [] arrayForTurn)
{
    int temp = 0;
    int [] turnArray = new int [arrayForTurn.Length];
    for (int i = 0; i < arrayForTurn.Length / 2; i++)
    {
        temp = arrayForTurn[i];
        turnArray[i] = arrayForTurn[arrayForTurn.Length - 1 - i];
        turnArray[arrayForTurn.Length - 1 - i] = temp;
    }
    return turnArray;
}
int [] turnedArray = TurnArray(userArray);

Console.ForegroundColor = ConsoleColor.Yellow;
PrintUserArray(userArray);
Console.ForegroundColor = ConsoleColor.Green;
PrintUserArray(turnedArray);

