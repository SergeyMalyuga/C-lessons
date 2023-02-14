// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите число №1");
String answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
Console.WriteLine("Введите число №2");
String answer2 = Console.ReadLine();
int number2 = Convert.ToInt32(answer2);

if (number % number2 == 0)
{
    Console.WriteLine (number+" "+number2+" -> кратно");
}
else
{
    int ost = number % number2;
    Console.WriteLine (number+" "+number2+" -> не кратно, остаток "+ost);
}

