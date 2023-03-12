// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки массива
// 1 4 7 2   -> 7 4 2 1
// 5 9 2 3   -> 9 5 3 2 
// 8 4 2 4   -> 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  //  [rows, columns] = [0,1]
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void SortElemRow(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[k, j] < matrix[k, j + 1])
                {
                    int temp = matrix[k, j];
                    matrix[k, j] = matrix[k, j + 1];
                    matrix[k, j + 1] = temp;
                }
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

SortElemRow(array2d);
PrintMatrix(array2d);