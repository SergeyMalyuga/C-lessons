// Задача 2: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите число №1");
String answer1 = Console.ReadLine();
int number1 = Convert.ToInt32(answer1);
Console.WriteLine("Введите число №2");
String answer2 = Console.ReadLine();
int number2 = Convert.ToInt32(answer2);
Console.WriteLine("Введите число №3");
String answer3 = Console.ReadLine();
int number3 = Convert.ToInt32(answer3);
int max;

if (number1 > number2)
{
    max = number1;
}
else if (number1 < number2)
{
    max = number2;
}
else 
{
    max = number1;
}
if (number3 > max)
{
    max=number3;
}
Console.WriteLine (number1+(" ")+number2+(" ")+number3+(" -> ")+max);