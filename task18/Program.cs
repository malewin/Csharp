/* напишите программу которая принимает на вход номер четверти системы 
координат и выдает на выход диапазон значений координат точки в этой четверти */
//пример 
// 1 : [x > 0; y > 0]
// 2 : [x < 0; y > 0]
// 3 : [x < 0; y < 0]
// 4 : [x > 0; y < 0]

Console.WriteLine("Введите номер четверти системы координат");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

if (quarterNumber > 0 && quarterNumber < 5)
{
    if (quarterNumber == 1) {Console.WriteLine("диапазон значений координат точки в этой четверти [x > 0; y > 0]");}
    if (quarterNumber == 2) {Console.WriteLine("диапазон значений координат точки в этой четверти [x < 0; y > 0]");}
    if (quarterNumber == 3) {Console.WriteLine("диапазон значений координат точки в этой четверти [x < 0; y < 0]");}
    if (quarterNumber == 4) {Console.WriteLine("диапазон значений координат точки в этой четверти [x > 0; y > 0]");}
}
else {Console.WriteLine("такой четверти нет в Декартовой системе координат");}

