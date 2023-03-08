/* Задача №58.
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */

int InputData(String messageToUser)
{
    Console.Write(messageToUser);
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
            matrix[i, j] = Random.Shared.Next(0, 10);
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

int[,] ProductOfTwoMatrices(int[,] matrix, int[,] matrix2)
{
int[,] matrix3 = new int [matrix.GetLength(0), matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix3 [i,j] = matrix[i,j]*matrix2[i,j]; 
        }
    }
    return matrix3;
}

int m = InputData("Введите количество строк для первой матрицы: ");
int n = InputData("Введите количество столбцов для первой матрицы: ");
int[,] myMatrix = GetRanndomMatrix(m, n);

int a = InputData("Введите количество строк для второй матрицы: ");
int b = InputData("Введите количество столбцов для второй матрицы: ");
int[,] myMatrix2 = GetRanndomMatrix(a, b);
Console.WriteLine();
PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix2);
Console.WriteLine();
int[,] matrix3= ProductOfTwoMatrices(myMatrix, myMatrix2);
PrintMatrix(matrix3);



