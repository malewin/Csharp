/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное
45 -> 101101
3 -> 11
2 -> 10

*/

Console.WriteLine("Введите десятичное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

string Converter(int numberA)
{
    string numberB = String.Empty;
    int temp = 0;
    for (int i = numberA; i > 0 ; i = i / 2)
    {
        temp = i % 2;
        numberB = temp + numberB;
    }
    return numberB;
}

string result = Converter(userNumber);

Console.WriteLine(result);