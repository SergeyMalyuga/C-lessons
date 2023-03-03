/* Задача №46.
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

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

    int m = InputData("Введите количество строк");
    int n = InputData("Введите количество столбцов");
    int[,] myMatrix = GetRanndomMatrix(m, n);
    Console.WriteLine();
    PrintMatrix(myMatrix);

    


