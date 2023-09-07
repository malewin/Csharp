/* не используя рекурсию выведите на экран числа 
Фибоначи в зависимости от заданного количества */

Console.WriteLine("Сколько будет чисел в ряде Фибоначи?: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

void Fibo (int [] array)
{
    array[0] = 0;
    array[1] = 1;
    Console.Write($"[ {array[0]} {array[1]} ");
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Fibo(array);

