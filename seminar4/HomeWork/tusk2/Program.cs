// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(String messageToUser) // Ввод числа.
{
    Console.WriteLine(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse(answer, out int num);
    return num;
}

int sumNumber(int a) //Сумма цифр в числе.
{
    int rez = 0;
    while (a > 0)
    {
        rez = rez + (a % 10);
        a = a / 10;
    }
    return rez;
}

bool numberCheck(int number) //Проверка больше ли число нуля.
{
    if (number > 0)
    {
        return true;
    }
    else
    {
        Console.WriteLine("С отрицательными числами не работаю!");
        return false;
    }
}

int number = InputNumber("Введите число!");
if (numberCheck(number))
{
    int sum = sumNumber(number);
    Console.WriteLine(number + " -> " + sum);
}
