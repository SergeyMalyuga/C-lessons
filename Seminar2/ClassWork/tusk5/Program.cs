// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число №1");
String answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
Console.WriteLine("Введите число №2");
String answer2 = Console.ReadLine();
int number2 = Convert.ToInt32(answer2);

if (number2 == number*number || number == number2*number2)
{
    Console.WriteLine(number+" "+number2+" -> да");
}
else
{
    Console.WriteLine(number+" "+number2+" -> нет");
}