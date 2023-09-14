/* Пользователь вводит вводит с клавиатуры М чисел. 
Посчитайте сколько чисел больше нуля ввёл пользователь */

Console.Clear();

int [] UserArray()
{
    Console.WriteLine("Укажите длинну масиива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"Элемент {i} из {length - 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

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

int Counter(int[] readyArray)
{
    int result = 0;
    for (int i = 0; i <readyArray.Length; i++)
    {
        if ( readyArray[i] > 0) result++;
    }
    return result;
}

int [] array = UserArray();
PrintUserArray(array);
Console.WriteLine($"Пользователь ввёл {Counter(array)} чисел");

