/* 
Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник со сторонами такой длины.
*/


int [] FillUserArray()
{
    int [] array = new int [3];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int [] arrayOfTriangle = FillUserArray();

bool AnswerTriangle(int [] array)
{
    bool answer = false;
    if(array[0]+array[1] > array[2] 
    && array[1]+array[2] > array[0]
    && array[2]+array[0] > array[1])
    {
        answer = true;
    }
    return answer;
}

bool answer = AnswerTriangle(arrayOfTriangle)

void PrintAnswer(bool answer)
{
    if (answer = true)
    {
        Console.WriteLine("да, треугольник с такими сторонами существует");
    }
    else
    {
        Console.WriteLine("нет, из этих сторон нельзя сложить треугольник");
    }

}