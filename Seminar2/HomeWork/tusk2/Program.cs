// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число!");
String answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

while (number > 1000)
{
    number = number / 10;
}

if (number>=100)
{
int thirdNumber = number % 10;
Console.WriteLine(thirdNumber);
}
else
{
   Console.WriteLine(number+" -> третьей цифры нет"); 
}
