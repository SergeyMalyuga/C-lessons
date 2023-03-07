/* Задача №54. 
Задайте двумерный массив. Напишите программу, 
которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
 */

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
            matrix[i, j] = Random.Shared.Next(0, 30);
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

int[,] OrderingNumbers (int[,] matrix)
{
    // int min = matrix[i, j];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(1)-1; d++)
            {
            if (matrix[i, d]>matrix[i, d+1])
            {
                int temp = matrix[i, d];
                matrix[i, d]=matrix[i, d+1];
                matrix[i, d+1]=temp;
            }
            }
        }
    }
    return matrix;
}

int m = InputData("Введите количество строк");
int n = InputData("Введите количество столбцов");
int[,] myMatrix = GetRanndomMatrix(m, n);
Console.WriteLine();
PrintMatrix(myMatrix);
myMatrix = OrderingNumbers(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);