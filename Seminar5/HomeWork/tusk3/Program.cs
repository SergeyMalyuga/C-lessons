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

int[] randomArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(min, max);
    }
    return array;
}

int differenceMaxMin(int[] array)
{
    int rez = 0;
    int min = array[0];
    int max = array[0];
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
int[] array = randomArray(length, leftR, rightR);
int rez = differenceMaxMin(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {rez}");
