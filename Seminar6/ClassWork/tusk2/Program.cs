// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int n = 44;
int countOfDigits = 0;
int nCopy = n;

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

while (nCopy !=0)
{
    nCopy/=2;
    countOfDigits++;
}

int[] binaryNumber = new int [countOfDigits];

for (int i = 0;i<binaryNumber.Length; i++)
{
    binaryNumber[i] = n%2;
    n/=2;
}

Console.WriteLine($"[{string.Join(", ", binaryNumber)}]");
Console.WriteLine();
ReverseArray (binaryNumber);
Console.WriteLine($"[{string.Join(", ", binaryNumber)}]");
