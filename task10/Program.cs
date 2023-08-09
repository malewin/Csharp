/* Напишите программу, которая принимает на вход трезначное число и на выходе
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


Console.WriteLine("Введите трёхзначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber < 0) userNumber = userNumber * (-1);
if (userNumber <1000 && userNumber > 99)
{
    int secondNumber = userNumber / 10 % 10;
    Console.WriteLine($"вторая цифра числа = {secondNumber}");
}
else 
{
    Console.WriteLine("число не трёхзначное");
}