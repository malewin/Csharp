/* напишите программу,  которая принимает на вход два числа и выдаёт на выход
является ли одно число квадратом другого*/

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1==number2*number2 || number2==number1*number1)
{
    Console.WriteLine("Одно число - квадрат другого");
}
else 
{
    Console.WriteLine("каждое из чисел - не является квадратом другого");
}