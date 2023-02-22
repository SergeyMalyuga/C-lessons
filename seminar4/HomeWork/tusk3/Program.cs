// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] array = new int [8];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = Random.Shared.Next (0,100);
}
// Console.WriteLine (string.Join (",", array));
Console.WriteLine ($"[{string.Join (",", array)}]");
