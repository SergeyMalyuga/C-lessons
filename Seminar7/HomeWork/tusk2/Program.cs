/* Задача №50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
​Например, задан массив:
​1 4 7 2
​5 9 2 3
​8 4 2 4
​1 7 -> такого числа в массиве нет */

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
            matrix[i, j] = Random.Shared.Next(0, 101);
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


void number(int[,] matrix, int i, int j)
{
    if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else{
    matrix[i, j] = matrix[i, j];
    Console.WriteLine($"{i} {j} -> {matrix[i, j]}");
    }
    
}

int n = InputData("Введите количество строк: ");
int m = InputData("Введите количество столбцов: ");
int i = InputData("Введите номер строки: ");
int j = InputData("Введите номер столбца: ");
int[,] matrix = GetRanndomMatrix(n, m);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
number(matrix, i, j);