// Задача №24.
// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int inputData(String messageToUser)
{
    Console.Write(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

int[] getRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

(int, int) sumPositiveAndNegativeElements(int[] array) // использование кортежа.
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive = sumPositive + array[i];
        }
        else
        {
            sumNegative = sumNegative = array[i];
        }
    }
    return (sumPositive, sumNegative);
}

int length = inputData ("Введите длину массива: ");
int leftR = inputData ("Задайте левую границу случайного диапозона: ");
int rightR = inputData ("Задайте правую границу случайного диапозона: ");
int[] myArray = getRandomArray(length, leftR, rightR);
Console.WriteLine(string.Join(", ", myArray)); // перевод массива в строку
(int sumP, int sumN) = sumPositiveAndNegativeElements(myArray); // использование кортежа.
Console.WriteLine($"Сумма положительных элементов = {sumP}");
Console.WriteLine($"Сумма отрицательных элементов = {sumN}");
