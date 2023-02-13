// Задача 1: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число №1");
String answer1 = Console.ReadLine();
int number1 = Convert.ToInt32(answer1);
Console.WriteLine("Введите число №2");
String answer2 = Console.ReadLine();
int number2 = Convert.ToInt32(answer2);
int max = 0;
int min = 0;

if (number1 > number2)
{
    max = number1;
    min = number2;
}

else if (number1 < number2)
{
    max = number2;
    min = number1;
}
else
{
    max = number1;
    min = number2;
}


Console.WriteLine("a=" + number1 + " b=" + number2 + " -> " + "max=" + max + " min=" + min);