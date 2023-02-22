// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(String messageToUser)
    {
    Console.WriteLine (messageToUser);
    String answer = Console.ReadLine();
    int.TryParse (answer, out int num);
    return num;
     }
int Exponentiation (int a, int b)
{
    int rez = 1;
    for (int i = 0; i<b; i++)
    {
    rez = rez*a;
    }
    return rez;
}

bool NaturalDegree (int a)
{
    if (a<0)
    {
        Console.WriteLine (a+" -> не натульная степень");
        return false;
    }
    return true;
}
int number = InputNumber("Введите число!");
int degree = InputNumber ("Введите натуральную степень!");
if (NaturalDegree (degree))
{
int rez = Exponentiation (number,degree);
Console.WriteLine (rez);
}
