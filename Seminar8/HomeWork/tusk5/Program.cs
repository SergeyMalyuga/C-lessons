/* // Задача №62.
// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7 */

// Программа работает с любой квадратной матрице [4,4]; [5,5] .... [10,10] и т.д.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,3}", matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
int y = 0;
int x = 0;
int n = array.GetLength(1);
int imin = 0;
int imax = n;
int jmin = 0;
int jmax = n;
int sum = 0;
int count = 1;

while (sum <= 16)
{
    for (int i = y, j = x; j < jmax; j++)
    {
        if (count > 16)
        {
            break;
        }
        array[i, j] = count++;
    }
    for (int i = x + 1, j = jmax - 1; i < imax; i++)
    {
        if (count > 16)
        {
            break;
        }
        array[i, j] = count++;
    }
    for (int j = jmax - 2, i = imax - 1; j >= jmin; j--)
    {
        if (count > 16)
        {
            break;
        }
        array[i, j] = count++;
    }

    for (int i = imax - 2, j = jmin; i > imin; i--)
    {
        if (count > 16)
        {
            break;
        }
        array[i, j] = count++;
    }
    x += 1;
    y += 1;
    n = n - 1;
    imax = n;
    jmax = n;
    imin += 1;
    jmin += 1;
    sum = count;
}

PrintMatrix(array);
Console.WriteLine();
