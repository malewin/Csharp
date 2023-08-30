/* напишите программу, которая принимает на вход пятизначное число и показывает
является ли оно полиндромом */

// 65456 - да
// 12567 - нет

Console.WriteLine ("Input 5-symbol number: ");

int userNumber = Convert.ToInt32(Console.ReadLine());
int mirrorNumber = 0;

if (userNumber < 0) 
{
    userNumber = userNumber * (-1);
}
for (int i = userNumber; i > 0; i = i / 10)
{
    mirrorNumber = userNumber % 10 + mirrorNumber * 10;
}
if (mirrorNumber == userNumber) {Console.WriteLine($"number {userNumber} is polindrom");}
else {Console.WriteLine($"number {userNumber} isn't polindrom");}