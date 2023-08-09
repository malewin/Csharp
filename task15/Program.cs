/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int [] budni = {1,2,3,4,5};
int [] vyhodnye = {6,7};
Console.WriteLine("Введите цифру дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number == budni[0] || number == budni[1] || number == budni[2] || number == budni[3] || number == budni[4])
{
    Console.WriteLine("Это не выходной");
}
else if (number == vyhodnye[0] || number == vyhodnye[1])
{
    Console.WriteLine("УРА! - выходной");
}
else if (number != budni[0] || number != budni[1] || number != budni[2] || number != budni[3] || number != budni[4] && number != vyhodnye[0] || number != vyhodnye[1])
{
    Console.WriteLine("Такого дня недели нет");
}