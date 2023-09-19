/*
67. Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
*/

int SumOfSymbolsInNumber (int number)
{
   if (number == 0)
   return 0;
   else
   return number % 10 + SumOfSymbolsInNumber(number/10);
}

int result = SumOfSymbolsInNumber(1234);
Console.WriteLine(result);