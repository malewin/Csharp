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

int [] GetRandomArray(int arrayL, int minBorder, int maxBorder)  // "метод задания массива" пользователем
{
    int [] array1 = new int [arrayL];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i]= new Random().Next(minBorder,maxBorder);
    }
    return array1;
}
int [] userArray = GetRandomArray(arrayL, minBorder, maxBorder);  //задаём переменную массива через метод "задания массива"
void PrintUserArray(int [] userArray)                             // "метод вывода старого массива" на экран
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
int [] NewArrayFromProizvPairElements (int [] array)         // "метод возвращения нового массива" из элементов - произведений старого
{
    if (arrayL % 2 == 0)                                     // случай (1) , когда в "старом" массиве четное количество элементов (нечетное количество индексов)
    {
        int[] newArray = new int[(arrayL / 2)];              // создаём переменную возвращаемого массива с количеством элементов в 2 раза меньше чем у старого
        int proizvOfPair = 0;                                // задаём переменную в которую будем класть произведение пар элементов из старого
        int nextEndIndex = array.Length - 1;                 // задаём переменную конечного индекса старого массива которую будем декременировать каждый цикл
        for (int i = 0; i < array.Length / 2; i++)           // крутим цикл пока индекс массива меньше количества элементов старого массива поделенных на 2. (пример: было 12, стало 6, 0<=i<=5)
        {
            proizvOfPair = array[i] * array[nextEndIndex];   // в каждом цикле для поледующего индекса вычисляем произведение пары элемента со стороны начала на элемент со стороны конца старого массива
            newArray[i] = proizvOfPair;                      // каждое последующее произведенеие присваиваем в новый последующий индекс нового возвращаемого массива
            nextEndIndex--;                                  // декременируем (отнимаем на 1) индекс со стороны конца массива
        }
        return newArray;                                     // возвращаем новый массив с заполненными индексами элементов
    }
    else                                                     // иначе: случай (2), когда в "старом" массиве нечетное количество элементов (четное количество индексов)
    {
        int[] newArray = new int[(arrayL / 2) + 1];          // создаём переменную возвращаемого массива с количеством элементов в 2 раза меньше чем у старого + 1 (было 13 - стало 7 (6пар плюс центр))
        int proizvOfPair = 0;                                // задаём переменную в которую будем класть произведение пар элементов из старого
        int nextEndIndex = array.Length - 1;                 // задаём переменную конечного индекса старого массива которую будем декременировать каждый цикл
        for (int i = 0; i <= nextEndIndex; i++)              // крутим цикл пока индекс со стороны начала массива не станет равен индексу со стороны конца (сойдутся в центр. индексе включая этот случай)
        {
            if(i == nextEndIndex)                            // если индексы парных сошлись в центральном индексе 
            {
                newArray[i] = array[i];                      // то индексу нового массива присваиваем тоже значение , что и в старом
            }
            else                                             // во всех остальных случаях - аналогично действиям из "случая (1)"
            {
            proizvOfPair = array[i] * array[nextEndIndex];   // в каждом цикле для поледующего индекса вычисляем произведение пары элемента со стороны начала на элемент со стороны конца старого массива
            newArray[i] = proizvOfPair;                      // каждое последующее произведенеие присваиваем в новый последующий индекс нового возвращаемого массива
            nextEndIndex--;                                  // декременируем (отнимаем на 1) индекс со стороны конца массива
            }
        }
        return newArray;                                     // возвращаем новый массив с заполненными индексами элементов
    }
}
int [] newArray = NewArrayFromProizvPairElements(userArray); // задаём переменную нового массива через "метод возвращения нового массива"

void PrintNewArray()                                        // "метод вывода нового массива" на экран
{
    if (arrayL % 2 == 0)
    { 
        Console.WriteLine("");
        Console.WriteLine("Ваш новый массив из попарных произведений:  ");
        Console.Write($"[");
        for (int i = 0; i < arrayL / 2; i++)
        {
            Console.Write($" {newArray[i]},");
        }
        Console.Write($" ]");
    }
    else
    {
        int nextEndIndex = arrayL - 1; 
        Console.WriteLine("");
        Console.WriteLine("Ваш новый массив из попарных произведений:  ");
        Console.Write($"[");
        for (int i = 0; i <= nextEndIndex; i++)
        {
            if (i == nextEndIndex)
            {
                Console.Write($" {newArray[i]},");
            }
            else
            {
                Console.Write($" {newArray[i]},");
                nextEndIndex--;  
            }
        }
        Console.Write($" ]");
    } 
}
PrintUserArray(userArray);
PrintNewArray();