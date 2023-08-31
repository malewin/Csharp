/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N включительно
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int ProizvedenieDoChisla(int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
     count = count * i;
    }
    return count;
}

Console.WriteLine($"произведение чисел от 1 до {userNumber} = {ProizvedenieDoChisla(userNumber)}");