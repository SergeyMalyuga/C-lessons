// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int inputData(String messageToUser)
{
    Console.WriteLine(messageToUser);
    string answer = Console.ReadLine();
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

int[] newLengthArray(int[] array)
{

    if (array.Length % 2 == 0)
    {
        return new int[array.Length / 2];
    }
    else
    {
        return new int[array.Length / 2 + 1];
    }

}

int[] NewArray(int[] array)
{
    int[] newArray = newLengthArray(array);
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0)
    {
        newArray[newArray.Length - 1] = array[array.Length / 2];
    }
    return newArray;
}

int length = inputData("Введите длину массива: ");
int leftR = inputData("Задайте левую границу случайного диапозона: ");
int rightR = inputData("Задайте правую границу случайного диапозона: ");
int[] array = randomArray(length, leftR, rightR);
Console.WriteLine(string.Join(", ", array));

int[] newArray = NewArray(array);
Console.WriteLine(string.Join(", ", newArray));
