// Задача №53. 
// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.


int InputData(String messageToUser)
{
    Console.WriteLine(messageToUser);
    string answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

int[,] GetRanndomMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeLine(int[,] array)
{
    //   for (int i = 0; i < matrix.GetLength(0)-1; i++)
    //     {
    for (int j = 0, i=0; j < array.GetLength(1); j++)
    {
        int temp = array[i,j];
        array[i,j] = array[array.GetLength(0) - 1,j];
        array[array.GetLength(0) - 1,j] = temp;
    }
    return array;
}
// }
int m = InputData("Введите количество строк");
int n = InputData("Введите количество столбцов");
int[,] myMatrix = GetRanndomMatrix(m, n);
Console.WriteLine();
PrintMatrix(myMatrix);
myMatrix = ChangeLine(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
