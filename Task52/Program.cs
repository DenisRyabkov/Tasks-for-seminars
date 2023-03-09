// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце
//
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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
       Console.Write("[");
       for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 3} ");
    } 
    Console.WriteLine("]");
}
}

void GetSumColumns(int[,] matrix)
{
    double sum;
    double result;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       sum = 0;
       result = 0;
       for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i,j];
        result = sum / matrix.GetLength(0);
    } 
    Console.WriteLine($"Столбец {j+1}:  Сумма:{sum}; Среднее арифметическое:{Math.Round(result,2)}");
}
}


int[,] matrix = CreateMatrixRndInt(3,4, 1, 10);
PrintMatrix(matrix);

GetSumColumns(matrix);
