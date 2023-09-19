/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите число first: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число second: ");
int second = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int first, int second)
 {
     int answer = 0;
     if (first != 0)
     {
         if (second != 0)
         {
             answer = AkkermanFunction(first-1, AkkermanFunction(first, second -1));
         }
         else answer = AkkermanFunction(first - 1, 1);
     }
     else answer = second + 1; 
     return answer;
 }

 Console.Write(AkkermanFunction(first, second));
