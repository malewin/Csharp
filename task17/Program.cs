/* напишите программу, которая принимает на вход точку координат x и y,
при чём x != 0 и y != 0, и выдаёт номер четверти плоскости в которой находится точка */

// 1ая четверть : x > 0 ; y > 0
// 2ая четверть : x < 0 ; y > 0
// 3ая четверть : x < 0 ; y < 0
// 4ая четверть : x > 0 ; y < 0

//void PointSelectMethod(int coordX, int coordY)
Console.WriteLine("Введите координату X вышей точки");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y вышей точки");
int coordY = Convert.ToInt32(Console.ReadLine());

if(coordX > 0 && coordY > 0) 
{
Console.WriteLine($"Точка [{coordX}:{coordY}] находится в первой четверти системы координат");
}
if(coordX < 0 && coordY > 0) 
{
Console.WriteLine($"Точка [{coordX}:{coordY}] находится во второй четверти системы координат");
}
if(coordX < 0 && coordY < 0) 
{
Console.WriteLine($"Точка [{coordX}:{coordY}] находится в третьей четверти системы координат");
}
if(coordX > 0 && coordY < 0) 
{
Console.WriteLine($"Точка [{coordX}:{coordY}] находится в четвёртой четверти системы координат");
}

