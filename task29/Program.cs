
Console.WriteLine($"Введите 8 чисел массива по 1 числу через enter: ");

int[] EnterNumbersOfArray()
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int [] readyUserArray = EnterNumbersOfArray();

void PrintUserArray(int [] userArray)
{
    Console.Write($"Ваш массив:[");
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

PrintUserArray(readyUserArray);
