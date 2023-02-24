// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumOddNumbers (int [] array)
{
    int sum=0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2!=0)
        {
            sum = sum+array[i];
        }
    }
    return sum;
}

int length = inputData("Введите длину массива: ");
int leftR = inputData("Задайте левую границу случайного диапозона: ");
int rightR = inputData("Задайте правую границу случайного диапозона: ");
int [] array = randomArray (length, leftR, rightR);
int rez = sumOddNumbers (array);
Console.WriteLine ($"[{string.Join(", ",array)}] -> {rez}");
