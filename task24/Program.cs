/* Напишите программу, которая принимает на вход
число А и выдаёт сумму чисел от 1 до А */

Console.WriteLine("Введите число А");
int userNumber = Convert.ToInt32(Console.ReadLine());


int SummOfNumber(int number)
{
    int summ = 0;
    for (int i = 1; i <= userNumber; i++)
    {
        summ = summ + i;
    }
    return summ;
}

Console.WriteLine($"сумма цифр до числа {userNumber} включительно равна {SummOfNumber(userNumber)}");