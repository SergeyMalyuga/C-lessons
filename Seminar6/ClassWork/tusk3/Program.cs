﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// F(x) = f(x-1) + f(x-2)

int inputData(String messageToUser)
{
    Console.WriteLine(messageToUser);
    string answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

int number = inputData ("Введите число: ");

int [] array = new int [number];
array[0]=0;
array[1]=1;

for (int i=2; i<array.Length; i++)
{
array[i]=array[i-1]+array[i-2];
}
Console.WriteLine();
Console.WriteLine($"{string.Join(", ", array)}");
