// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



// int numberInt = Random.Shared.Next(1, 10);
// double numberDouble = Random.Shared.NextDouble() * 100 - 20;
// double[] doubles = new double[] {2.35345345, 1.392391392, 234.234236546 };
// Console.WriteLine($"{string.Join(", ", doubles.Select(x => Math.Round(x, 2)))}"); // [-20.0, 80.0)

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

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

const int LENGTH = 12;
const int LEFTBORDER = -10;
const int RIHTBORDER = 10;

int[] array = randomArray(LENGTH, LEFTBORDER, RIHTBORDER);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine();
ReverseArray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");

