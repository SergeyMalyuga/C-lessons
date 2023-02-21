// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine ("Введите число!");
String answer = Console.ReadLine();
if (int.TryParse(answer, out int number))
{
    int count = 0;
    while (number>0)
    {
    number = number/10;
    count = count+1;
    }
    Console.WriteLine(count);
}
else 
{
    Console.WriteLine ("Вы ввели не число!");
}