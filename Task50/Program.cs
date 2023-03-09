// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или указание, что такого элемента нет
//
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.WriteLine ("Введите номер строки");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите номер столбца");
int number2 = Convert.ToInt32(Console.ReadLine());

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

void PrintElement(int[,] matrix, int i, int j)
{
 Console.WriteLine ();

    if(i > matrix.GetLength(0)) Console.WriteLine("Такого элемента в массиве нет");
    else if(j > matrix.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет");
    else  Console.WriteLine ($"Искомый элемент массива: {matrix [i,j]}");
}


int[,] array2d = CreateMatrixRndInt(3,4,-10,10);
PrintMatrix(array2d);

PrintElement(array2d, number1, number2);

