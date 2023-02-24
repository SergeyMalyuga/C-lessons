// Задача №33.
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool numberInarray(int[] array, int number)
{
bool result = false;
for (int i = 0; i<array.Length; i++)
    if (array[i] == number)
    {
    result = true;
    break;
    }
    return result;
}


int length = inputData("Введите длину массива: ");
int leftR = inputData("Задайте левую границу случайного диапозона: ");
int rightR = inputData("Задайте правую границу случайного диапозона: ");
int number = inputData("Введите число: ");
int[] array = getRandomArray(length, leftR, rightR);
Console.WriteLine(string.Join(", ", array));
bool res = numberInarray(array, number);
Console.WriteLine (res);
