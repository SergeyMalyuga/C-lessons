// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int inputData(String messageToUser)
{
    Console.WriteLine(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

int[] randomArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(min, max);
    }
    return array;
}

int evenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int length = inputData("Введите длину массива: ");
int leftR = inputData("Задайте левую границу случайного диапозона: ");
int rightR = inputData("Задайте правую границу случайного диапозона: ");
if (leftR >= 100 && leftR < 1000 && rightR >= 100 && rightR < 1000)
{
    int[] array = randomArray(length, leftR, rightR);
    int rez = evenNumbers(array);
    Console.WriteLine($"[{string.Join(", ", array)}] -> {rez}");
}
else
{
Console.WriteLine ("Вы ввели недопустимое значение числа!");
}
