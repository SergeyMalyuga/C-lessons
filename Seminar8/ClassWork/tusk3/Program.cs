// Задача №57.
// Составить частотный словарь элементов двумерного массива. Частотный словарь 
// содержит информацию о том, сколько раз встречается элемент входных данных.

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

void PrintRepeats (int[,] matrix)
{
    int[] repeats = new int [10];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           int index = matrix [i,j];
           repeats[index]++;
        }
       
    }
    for (int i=0; i<repeats.Length; i++)
    {
Console.WriteLine($"{i} повторяется {repeats[i]} раз");
    }
}


int m = InputData("Введите количество строк");
int n = InputData("Введите количество столбцов");
int[,] myMatrix = GetRanndomMatrix(m, n);
Console.WriteLine();
PrintMatrix(myMatrix);
PrintRepeats(myMatrix);