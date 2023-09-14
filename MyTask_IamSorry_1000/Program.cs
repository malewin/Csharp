/* я извиняюсь тысячу раз */

string iamsorry = "прости меня,";

for (int i = 0; i < 1000; i++)
{
    if (i % 2 == 0)
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(iamsorry + " ");
    }
    else 
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(iamsorry + " ");
}

