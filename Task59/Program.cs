﻿// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива
//
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7
//
// 9 2 3 
// 4 2 4 
// 2 6 7

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

int[] IndexOfMinElem(int[,] matrix)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
       if(matrix[i,j] <= matrix[row, column])
       {
        row = i;
        column = j;
       }
     }   
    }
    return new int[] {row, column};
}

int[,] DeleteRowColumn(int[,] matrix, int[] array)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int m=0, n=0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
       if(m == array[0]) m++;
       for (int j = 0; j < newMatrix.GetLength(1); j++)
       {
        if(n == array[1]) n++;
        newMatrix[i,j] = matrix[m,n];
        n++;
       } 
       m++;
       n=0;
    }
    return newMatrix;
}

int[,] array2d = CreateMatrixRndInt(3,3,0,10);
PrintMatrix(array2d);
Console.WriteLine();

int[] indexOfMinElem = IndexOfMinElem(array2d);

int[,] newArray2d = DeleteRowColumn(array2d, indexOfMinElem);
PrintMatrix(newArray2d);