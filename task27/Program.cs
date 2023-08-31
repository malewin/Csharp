/* 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
*/

Console.WriteLine($"Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

double summOfSymbols(int number)
{   
    if(number < 0) {number = number * (-1);}
    int result = 0;
    for (int i = number; i > 0; i /= 10 )
    {
        result = i % 10 + result;
    }
    return result;
}

Console.WriteLine($"Сумма цифр числа {userNumber} равна {summOfSymbols(userNumber)}");