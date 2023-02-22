// Задача 29: Напишите программу, которая задаёт массив из 
// количества элементов заданным пользователем. Данный массив
// заполняется числами из заданного пользователем диапозона и
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int inputData (String messageToUser)
{
    Console.Write (messageToUser);
    String answer = Console.ReadLine();
    int.TryParse (answer, out int number);
    return number;
}

int [] generateArray (int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i< array.Length; i++)
    {
        array [i] = Random.Shared.Next(min, max+1);
    }
    return array;
}

int length = inputData ("Введите длину массива: ");
int min = inputData ("Определите начало диапозона заполнения массива: ");
int max = inputData ("Определите конец диапозона заполнения массива: ");
int [] arr = generateArray (length, min, max);
Console.WriteLine ();
Console.WriteLine (string.Join(", ", arr));
