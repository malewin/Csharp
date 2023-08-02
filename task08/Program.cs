/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: N= ");
int number = Convert.ToInt32(Console.ReadLine());


if (number <= 1)
{
    Console.WriteLine("Чётных чисел, удовлетворяющих условию задачи, - нет");
}
else
Console.WriteLine("Числа в диапазоне от 1 до вашего числа N: ");
for (int i = 2; i <= number; i=i+2)
{
    Console.Write(i+ ", "); 
}
