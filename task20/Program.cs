/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2-D пространстве */

Console.WriteLine("Input [x, y] coordinates for А-point");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" A-point: [{xA},{yA}]");

Console.WriteLine("Input [x, y] coordinates for B-point");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" B-point: [{xB},{yB}]");

double diffAB = Math.Sqrt ((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));

Console.WriteLine($"Different between A-point and B-point: {diffAB}");
