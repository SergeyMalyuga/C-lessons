// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int inputData(String messageToUser)
{
    Console.WriteLine(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

double[] randomArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        int del = Random.Shared.Next(1, 5);
        array[i] = (double)Random.Shared.Next(min, max) / del;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

double differenceMaxMin(double[] array)
{
    double rez = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        else if (array[i] > max)
        {
            max = array[i];
        }
        rez = max - min;
    }
    return rez;
}

int length = inputData("Введите длину массива: ");
int leftR = inputData("Задайте левую границу случайного диапозона: ");
int rightR = inputData("Задайте правую границу случайного диапозона: ");

double[] array = randomArray(length, leftR, rightR);
double rez = differenceMaxMin(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {rez}");

