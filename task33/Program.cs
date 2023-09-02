/*
Задайте массив. Напишите программу, которая определяет присутствует ли данное число в массиве.
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
Console.WriteLine("Введите искомое число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

bool Detector(int [] array, int userNumber)
{
    bool answer = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == userNumber) 
        {
            answer = true;
        }
    }
    return answer;
}

bool answer = Detector (userArray, userNumber);

void AnswerPrint()
{
    if (answer == true)
    {
        Console.WriteLine($". И он содержит искомое число {userNumber}");
    }
    else 
    {
       Console.WriteLine($". И он не содержит искомое число {userNumber}"); 
    }
}
PrintUserArray(userArray);
AnswerPrint();


