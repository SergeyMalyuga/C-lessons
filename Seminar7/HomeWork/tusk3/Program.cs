/* Задача №52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
​Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

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

void ArithmeticMean(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum=0;
        double rez=0;
      for (int i = 0; i < matrix.GetLength(0); i++)  
      {
        sum+=matrix[i,j];
      }
      rez=(double)sum/matrix.GetLength(0);
      rez=Math.Round(rez,1);
      Console.WriteLine(rez);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,5}",matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int n = InputData("Введите количество строк: ");
int m = InputData("Введите количество столбцов: ");
int[,] matrix = GetRanndomMatrix(n, m);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
ArithmeticMean(matrix);