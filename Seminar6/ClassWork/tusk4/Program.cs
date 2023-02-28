int[] randomArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(min, max);
    }
    return array;
}

const int LENGTH = 12;
const int LEFTBORDER = -10;
const int RIHTBORDER = 10;

int[] array = randomArray(LENGTH, LEFTBORDER, RIHTBORDER);
int[] array2 = new int [array.Length];

for (int i = 0; i< array2.Length; i++)
{
    array2[i] = array[i];
}

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", array2)}]");

