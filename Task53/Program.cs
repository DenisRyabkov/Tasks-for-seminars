// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строки массива

int [,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  //  [rows, columns] = [0,1]
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max+1);
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
        Console.Write($"{matrix[i, j], 4} ");
    } 
    Console.WriteLine();
}
}

void GetReplacingString (int[,] matrix)
{                                                   // int firstRow = 0; int lastRow = matrix.GetLength(0)-1;
for (int j = 0; j < matrix.GetLength(1); j++) 
{
  int temp = matrix[0,j];                            // matrix[0,j] тоже matrix[firstRow,j]; 
  matrix[0,j] = matrix[matrix.GetLength(0)-1,j];     // ... = matrix[lastRow,j];
  matrix[matrix.GetLength(0)-1,j] = temp;
}
}


int[,] array2d = CreateMatrixRndInt(3,4,-100,100);
PrintMatrix(array2d);
Console.WriteLine();

GetReplacingString(array2d);
PrintMatrix(array2d);