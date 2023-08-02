/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два бех остатка).

4 -> да
-3 -> нет
7 -> нет 
Дополнительно: + выдаёт информацию если число ещё и отрицательное.
*/

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2 == 0 && number >= 0)
{
  Console.WriteLine ("Число чётное!"); 
}
else
if(number%2 == 0 && number < 0)
{
  Console.WriteLine ("Число чётное! и отрицательное"); 
}
else
if(number > 0)
{
   Console.WriteLine ("Число нечётное... :( ");  
}
else
if(number < 0)
{
   Console.WriteLine ("Число нечётное и отрицательное");  
}