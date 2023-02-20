// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число!");
String answer = Console.ReadLine();
int rez = 0;

if (int.TryParse(answer, out int number)) // проверка ввёл ли пользователь число.
{
    int temp = number;
    if (number > 10000 && number < 100000)
    {
        while (temp > 0)
        {
            rez = rez * 10 + temp % 10;
            temp = temp / 10;
        }
        if (number == rez)
        {
            Console.WriteLine(number + " -> да, число является палиндромом!");
        }
        else
        {
            Console.WriteLine(number + " -> нет, число не является палиндромом!");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число!");
    }
}
else
{
    Console.WriteLine("Вы ввели не число!");
}
