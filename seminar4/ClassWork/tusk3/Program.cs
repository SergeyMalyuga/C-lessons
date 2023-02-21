// Задача 30: Напишите программу, которая выводит массив из 8
// //элементов, заполненный нулями и единицами в случайном порядке.
// //[1,0,1,1,0,1,0,0]

int[] array = new int[8];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = Random.Shared.Next(0, 2);
}
foreach (var a in array)
{
    Console.Write("{0} ", a);
}
// Console.WriteLine (string.Join (",", array));
// Console.WriteLine (string.Join ($"[{",", array}]"));
