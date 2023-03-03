/* Задача №47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
​m = 3, n = 4.
​0,5 7 -2 -0,2
​1 -3,3 8 -9,9
​8 7,8 -7,1 9
 */

int inputData(String messageToUser)
{
    Console.WriteLine(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

double[,] randomArray(int rows, int colums)
{
    double[,] matrix = new double[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j< matrix.GetLength(1); j++ )
        {
            double del = Random.Shared.Next(1,9);
            matrix[i,j]= Random.Shared.Next(-10,101)/del;
            matrix[i,j]= Math.Round(matrix[i,j], 1);
        }
       
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,8}",matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = inputData("Введите количество строк");
int n = inputData("Введите количество столбцов");
double[,] myMatrix = randomArray(m,n);
Console.WriteLine();
PrintMatrix(myMatrix);