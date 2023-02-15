// Задача 3: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели!");
String answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

if (number >= 1 && number <= 7)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine(number + " ->  да, день является выходным");
    }
    else
    {
        Console.WriteLine(number + " ->  нет, день не является выходным");
    }
}
else
{
    Console.WriteLine("нет такого дня недели!");
}
