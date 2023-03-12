// Напишите программу, которая заполнит спирально массив 4 на 4 (или универсальный).
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixSpiralInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int k = 1;
    int t = 0;
    int i, j = 0;

    while (k <= matrix.Length)
    {
        for (i = t; i < rows; i++)
            matrix[j, i] = k++;
        j = rows - 1;
        for (i = t + 1; i < columns; i++)
            matrix[i, j] = k++;
        j = columns - 1;
        for (i = rows - 2; i >= t; i--)
            matrix[j, i] = k++;
        j = t;
        for (i = columns - 2; i > t; i--)
            matrix[i, j] = k++;
        rows--;
        columns--;
        t++;
        j = t;
    }
    return matrix;
}

void PrintMatrixSpiral(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixSpiralInt(rows, columns);
PrintMatrixSpiral(array2d);