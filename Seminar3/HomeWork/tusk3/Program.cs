// Задача №23!

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите число!");
String answer = Console.ReadLine();
if (double.TryParse(answer, out double number))
{
    Console.Write(number+" -> ");
    for (int i=1; i<=number; i++)
    {
    double rez = Math.Pow (i,3);
    Console.Write(rez+" ");
    }
}
else
{
    Console.WriteLine ("Вы ввели не число!");
}
