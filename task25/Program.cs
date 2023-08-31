/*
Напишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В.
*/

/*
void EnterAnumbers()
{
    Console.WriteLine("введите число А: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
}
EnterAnumbers(); // хотел ввод сделать через метод тоже, но запутался.
*/

Console.WriteLine("введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double AvStepeniB(int numberA, int numberB)
{
    if (numberB < 0) { numberB = numberB * (-1);}

    double result = Math.Pow(numberA, numberB);
    return result;
}

Console.WriteLine($"число {numberA} в натуральной степени {numberB} равно {AvStepeniB(numberA, numberB)}");
