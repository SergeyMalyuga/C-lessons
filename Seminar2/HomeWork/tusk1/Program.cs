// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число!");
String answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
if (number >= 100 && number < 1000)
{
    int thirdNumber = (number / 10) % 10;
    Console.WriteLine(number+" -> "+thirdNumber);
}
else
{
    Console.WriteLine("Вы ввели число, которое не является трёхзначным!");
}

