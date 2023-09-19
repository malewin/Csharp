/*
69. Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии.
*/




int SumOfSymbolsInNumber (int numberA, int numberB)
{
   if (numberB == 0)
   return 1;
   else
   return numberA * SumOfSymbolsInNumber(numberA, numberB-1);
}

int result = SumOfSymbolsInNumber(2, 10);
Console.WriteLine(result);
