/* Задача №60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
 */

int InputData(String messageToUser)
{
    Console.Write(messageToUser);
    string answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

int[,,] GetRanndomMatrix(int list, int rows, int colums)
{
    int[,,] matrix = new int[list, rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                matrix[i, j, d] = Random.Shared.Next(10, 30);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        for (int d = 0; d < matrix.GetLength(2); d++)
        {
            Console.Write($"{matrix[i, j, d]} ({i},{j},{d}) ");
        }
        }
        Console.WriteLine();
    }
}


int i = InputData("Введите количество листов: ");
int j = InputData("Введите количество строк: ");
int d = InputData("Введите количество столбцов: ");
int[,,] myMatrix = GetRanndomMatrix(i, j,d);
Console.WriteLine();
PrintMatrix(myMatrix);
