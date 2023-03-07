// Задача №55. 
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ChangeLine(int[,] array)
{
    int[,] Array = new int [array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0)==array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
      for (int j = 0; j < array.GetLength(1); j++)
        {
         
    
        
        Array[i,j] = array[j,i];
        
    
    }
   }  
   
}
else
{
Console.WriteLine ("Поменять местами строки на столбцы не возможно!");
}
 return Array;
}
int m = InputData("Введите количество строк");
int n = InputData("Введите количество столбцов");
int[,] myMatrix = GetRanndomMatrix(m, n);
Console.WriteLine();
PrintMatrix(myMatrix);
myMatrix = ChangeLine(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
