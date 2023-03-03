/* Задача №51. 
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
​Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной */

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
            matrix[i, j] = Random.Shared.Next(0, 101); ;

        }
    }
    return matrix;
}

int SumOfElements(int[,] matrix)
{
    int rez = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                rez = rez + matrix[i, j];
            }
        }
    }
    return rez;
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

int m = InputData("Введите количество строк");
int n = InputData("Введите количество столбцов");
int[,] myMatrix = GetRanndomMatrix(m, n);
PrintMatrix(myMatrix);
int rez = SumOfElements(myMatrix);
Console.WriteLine();
Console.WriteLine(rez);

