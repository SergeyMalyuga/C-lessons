
/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3, b = 9 -> нет
*/

Console.WriteLine("Введите число №1!");
String answer = Console.ReadLine();
int a = Convert.ToInt32(answer);
Console.WriteLine("Введите число №2!");
String answer2 = Console.ReadLine();
int b = Convert.ToInt32(answer2);

if (a == b * b)
{
    Console.WriteLine("a= " + a + " b=" + b + "-> да");
}
if (b == a * a)
{
    Console.WriteLine("a= " + a + " b=" + b + " -> да");
}
else
{
    Console.WriteLine("a= " + a + " b=" + b + " -> нет");
}
