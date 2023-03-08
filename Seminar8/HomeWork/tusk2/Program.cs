/* Задача №56. 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


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
void RowSmallestAmount(int[,] matrix)
{
   
    int[] arrayAmount = new int[matrix.GetLength(1)];
    
    int numberRow=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrayAmount[i] += matrix[i, j];
        }
    }
    int max = arrayAmount[0];
    for (int i = 0; i < arrayAmount.Length; i++)
    {
        
        if (arrayAmount[i] < max)
        {
            max = arrayAmount[i];
            numberRow=i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой ({max}) ---> Строка № {numberRow}");
}



int m = InputData("Введите количество строк");
int n = InputData("Введите количество столбцов");
int[,] myMatrix = GetRanndomMatrix(m, n);
Console.WriteLine();
PrintMatrix(myMatrix);
Console.WriteLine();
RowSmallestAmount(myMatrix);
