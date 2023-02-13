// Задача 3: Напишите программу, которая на вход принимает число и выдает, является ли число четным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число!");
String answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

if (number % 2 == 0)
{
    Console.WriteLine(number + " является чётным числом");
}
else
{
    Console.WriteLine(number + " не является чётным числом");
}