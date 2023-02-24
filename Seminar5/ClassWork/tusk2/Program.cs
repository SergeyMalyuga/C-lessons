// Задача №32. 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, 
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

int [] changeNumber (int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            array[i] = array[i] * (-1);
        }
        else if (array[i] < 0)
        {
            array[i] = array[i] * (-1);
        }
    }
    return array;
}

int length = inputData ("Введите длину массива: ");
int leftR = inputData ("Задайте левую границу случайного диапозона: ");
int rightR = inputData ("Задайте правую границу случайного диапозона: ");
int [] array = getRandomArray (length, leftR, rightR);
Console.WriteLine ();
Console.WriteLine(string.Join(", ", array)); // перевод массива в строку
changeNumber(array);
Console.WriteLine ();
Console.WriteLine (string.Join(", ", array)); // перевод массива в строку
