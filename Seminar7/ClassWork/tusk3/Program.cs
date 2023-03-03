/* Задача №49. 
Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты. */

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

    int m = InputData("Введите количество строк");
    int n = InputData("Введите количество столбцов");
    int[,] myMatrix = GetRanndomMatrix(m, n);
    PrintMatrix(myMatrix);
    EvenNumbersChanged(myMatrix);
    Console.WriteLine();
    PrintMatrix(myMatrix);


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

int [,] EvenNumbersChanged(int[,]matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i%2!=0 && j%2!=0)
            {
                matrix[i,j]=matrix[i,j]*2;
            }
        }
    }
    return matrix;
}

   

    